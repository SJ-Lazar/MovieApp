function my_function(message) {
    console.log("custom function" + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("MovieApp.Client", "GetCurrentCount")
        .then(result => { console.log("Count from javascript" + result) });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}