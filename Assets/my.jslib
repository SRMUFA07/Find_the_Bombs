mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },

  ShowAdv : function () {
    ysdk.adv.showFullscreenAdv({
      callbacks: {
        onClose: function(wasShown) {
          console.log("-------- close --------")
        },
        onError: function(error) {
          console.log("-------- error --------")
        }
      }
    })
  },

  GetTypePlatformDevice : function() {
    GetTypeDevice();
  },

});