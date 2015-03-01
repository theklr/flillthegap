var closethegap = {
    layout: {}
            , page: {
                handlers: {}
                , startUp: null
            }
            , services: { blogs: {} }
};


closethegap.layout.startUp = function () {

    console.debug("closethegap.layout.startUp");

    //this does a null check on sabio.page.startUp
    if (closethegap.page.startUp) {
        closethegap.page.startUp();
    }
};