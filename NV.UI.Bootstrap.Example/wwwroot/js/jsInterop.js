callFunctionOnObject = (object, functionName, arguments) => {
    if (typeof object === 'string')
        object = object.split(".").reduce((obj, prop) => obj[prop], window);
    return Array.isArray(arguments) ? object[functionName](...arguments) : object[functionName](arguments);
}