export function getTimestampJSON(timestamp) {
    var result = {
        unix: null,
        natural: null
    };

    var date;
    if (!isNaN(parseInt(timestamp))) {
        date = new Date(parseInt(timestamp));
    } else {
        date = new Date(timestamp);
    }

    if (!isNaN(date.getTime())) {
        result.unix = date.getTime();
        result.natural = getNaturalDate(date);
    }

    return result;
}

export function getNaturalDate(date) {
    var months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
    return `${months[date.getMonth()]} ${date.getDate()}, ${date.getFullYear()}`;
}