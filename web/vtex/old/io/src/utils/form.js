/**
 * Utils > Form
 */

import { StringUtil } from './index';

const DATA_TO_CLEAR = [
  'label', 'text', 'isValid', 'required', 'onChange',
  'isName', 'isEmail', 'isCpf', 'isDate', 'isPhone', 'isCep',
  'isNumber', 'isCreditCard', 'isMoney', 'onBlur', 'isFormSubmitted',
  'onFieldValidate', 'onComponentMount', 'onComponentUnmount', 'isLoading',
  'checked', 'defaultChecked', 'val', 'defaultValue'
];

export class FormUtil {
  static clearDataInput(data, optionalDataToClear) {
    let dataToClear = DATA_TO_CLEAR;

    if (Array.isArray(optionalDataToClear)) {
      dataToClear = dataToClear.concat(optionalDataToClear);
    }

    dataToClear.forEach((remove) => {
      delete data[remove];
    });
  }

  static commonFieldsValidations(fieldProps, fieldName, fieldValue) {
    if (fieldProps.required && StringUtil.isEmpty(fieldValue)) {
      throw new Error('Campo obrigatório');
    }
  }

  static parseValueFromProps(props = {}, nextProps = {}) {
    let value = null;

    if (nextProps.val !== props.val) {
      value = nextProps.val;
    } else if (nextProps.defaultValue !== props.defaultValue) {
      value = nextProps.defaultValue;
    }

    return value;
  }

  static parseCheckedFromProps(props = {}, nextProps = {}) {
    let checked = null;

    if (nextProps.checked !== props.checked) {
      checked = nextProps.checked; // eslint-disable-line prefer-destructuring
    } else if (nextProps.defaultChecked !== props.defaultChecked) {
      checked = nextProps.defaultChecked;
    }

    return checked;
  }

  static isName(value) {
    const regex = /^[a-záàâãéèêíïóôõöúçñ ]+$/g;

    return regex.test(value);
  }

  static isEmail(value) {
    const regex = /^\S+@\S+(\.\S{2,4})+$/g;

    return regex.test(value);
  }

  static isPhone(value) {
    const regex = /^(\(\d{2}\) \d{4,5}-\d{4})$/g;

    return regex.test(value);
  }

  static isCep(value) {
    const regex = /^(\d{5}-\d{3})$/g;

    return regex.test(value);
  }

  static isNumber(value) {
    const regex = /^(\d{0,9})$/g;

    return regex.test(value);
  }

  static isCpf(value) {
    return window.CPF.validate(value);
  }

  static isCreditCard(value) {
    value = value.replace(/\s/g, '');

    const creditCardList = [
      { flag: 'visa', rule: '^4[0-9]{0,15}$' },
      { flag: 'master', rule: '^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$' },
      { flag: 'amex', rule: '^3[47][0-9]{0,13}$' },
      { flag: 'diners', rule: '^3(?:0[0-5]|[68][0-9])[0-9]{0,11}$' },
      { flag: 'elo', rule: '^(((431274|457393|650901|650541|651652|636368|438935|504175|451416|636297)\\d{0,10})|(6516(?:5[2-9]|6[0-9]|7[0-9]))\\d{0,10}|(6505(?:0[0-9]|1[0-9]|2[0-9]|3[1-8]|4[1-9]|5[0-9]|6[0-9]|7[0-9]|8[0-9]|9[0-8]))\\d{0,10}|(6509(?:0[1-9]|1[0-9]|2(0)))\\d{0,10}|(5067(?:0(7|8)|1(5|7|8|9)|2(0|1|4|5|6|7|8|9)|3(0|1|2|3|9)|4[0-8]|5[0-3]|7[4-8]))\\d{0,10}|(4011(?:7(8|9)))\\d{0,10}|(4576(?:3(1|2)))\\d{0,10}|(6504(?:0[5-9]|1[0-9]|2[0-9]|3[0-9]|8[5-9]|9[0-9]))\\d{0,10}|(6507(?:0[0-9]|1[0-8]|2[0-7]))\\d{0,10}|(6550(?:0[0-9]|1[0-9]|2[1-9]|3[0-9]|4[0-9]|5[0-8]))\\d{0,10}|(509[1-7])\\d{0,12}|(5098(?:0[0-9]|1(0)))\\d{0,10}|(5090(?:0(0|1|2|4|5|6|7|8|9)|1[2-9]|2[0-9]|3[1-9]|4[0-9]|5[0-9]|6(0|1|2|3|4|6|7|8|9)|7(0|1|2|4|5|6|7|8|9)|8(0|1|2|3|5|6|7|8|9)|9[0-9])\\d{0,10}))$' }
    ];

    for (let key in creditCardList) {
      if (new RegExp(creditCardList[key].rule).test(value)) return creditCardList[key].flag;
    }
    return false;
  }

  static isMoney() {

  }

  static getFieldError(field) {
    let fieldError = null;
    const { error, isFieldChanged, isFieldBlurred } = field.state;
    const { isFormSubmitted } = field.props;

    if (isFormSubmitted || isFieldChanged || isFieldBlurred) {
      fieldError = error;
    }

    return fieldError;
  }
}
