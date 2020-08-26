import { resolve } from "path";

import Ajv from 'ajv';

import * as TJS from "typescript-json-schema";
import { Constants } from "./constants";

// optionally pass argument to schema generator
const settings: TJS.PartialArgs = {
    required: true
};

// optionally pass ts compiler options
const compilerOptions: TJS.CompilerOptions = {
    strictNullChecks: true
}

// optionally pass a base path
const basePath = __dirname;

const program = TJS.getProgramFromFiles([resolve("constants.d.ts")], compilerOptions, basePath);

const generator = TJS.buildGenerator(program, settings);

if (!generator) {
    throw new Error('There is no generator!')
}

// all symbols
const symbols = generator.getUserSymbols();

// Get symbols for different types from generator.
var ajv = new Ajv(); // options can be passed, e.g. {allErrors: true}
var validate = ajv.compile(generator.getSchemaForSymbol("Constants"));

console.log('validate({}) => ', validate({}))
console.log('validate.errors', validate.errors);
console.log("validate(<Constants>{ banners: [{ image: '' }], config1: '', config2: [1] }) => ", validate(<Constants>{ banners: [{ image: '' }], config1: '', config2: [1] }))
console.log('validate.errors', validate.errors);
console.log("validate(<Constants>{ banners: [], config1: '', config2: [1] }) => ", validate({ banners: [], config1: '', config2: [1] }))
console.log('validate.errors', validate.errors);
console.log("validate(<Constants>{ banners: [], config1: '', config2: [1] }) => ", validate({ config2: [1] }))
console.log('validate.errors', validate.errors);

