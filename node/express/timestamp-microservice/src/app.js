import express from 'express';
import { getTimestampJSON, getNaturalDate } from './utils/time-utils';

export const app = express();

app.get('/', (request, response) => {
    response.status(200).send('Use a timestamp or natural date as path parameter to get the timestamp object e.g.: /October%201,%202016 or /1477473583462');
});

app.get('/:timestamp', (request, response) => {
    var timestamp = request.params.timestamp;
    response.status(200).json(getTimestampJSON(timestamp));
});