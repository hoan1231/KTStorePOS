
    printerServer='';
(function () {
    'use strict'
    var config = angular.module('pos.session', []);
    config.partialBase = '/Content/';
    config.partial = function (name, dir) {
        if (!dir)
            dir = 'vendor';
        return config.partialBase + dir + '/partial/' + name;
    };
    var session = {
    loginUrl : '/Signin',
    reportingDomain : 'https://reporting.pos365.vn',
    jsVersion:10.0,
    rootUrl : 'https://{0}.pos365.vn',
    baseApi: '/api/',
    rid: 'MAxFH1xNMpQ=',
    bid: 'nT3trQZEMUQ=',
    websockets:['webSockets','longPolling'],
    retailer:{"Id":20711,"Code":"mptest","Name":"mpTest","Address":null,"Phone":"0346847121","Logo":null,"Status":1,"ExpiryDate":"2019-05-17T16:52:34.543","FieldId":8,"LatestClearData":"2019-05-10T16:55:03.373","Province":"HA NOI","UsingCustomLogo":false,"TelephoneOfShopkeepers":"0346847121","SmsBrandName":null,"Description":null},
    branch :{"Id":33851,"Name":"HA NOI","Email":"congbinhnc@gmail.com","Phone":"0346847121","Address":null,"RetailerId":20711,"CreatedDate":"2019-05-10T16:52:34.857","CreatedBy":0,"ModifiedBy":null,"ModifiedDate":null,"IsOnline":true,"PreOrderCode":null,"FieldId":null,"PreProductCode":null,"PrintTemplates":[],"Transfers":[],"Transfers1":[]},
    user:{"Id":51310,"UserName":"0346847121","Name":"Admin","IsAdmin":true},
    auditusers:{"51310":"Admin"},
    branchs:[{"Id":33851,"Name":"HA NOI"},{"Id":33852,"Name":"Chi nhánh 2"}],
    accounts:[{"Id":978,"Name":"QR Code"}],
    partialBase: config.partialBase,
    partialPath: config.partial,
    pointconfig:{"Id":0,"CreatedBy":0,"CreatedDate":"0001-01-01T00:00:00","ModifiedBy":null,"ModifiedDate":null,"RetailerId":0,"ValueToPoint":0.0,"PointToValue":0.0,"ExcludeOrderDiscount":false,"ExcludeProductDiscount":false}
    };
    config.value('posSession', session);
    var settings = {"IPFilterConfiguration":"","IPAddressPrintServer":"","DifferentiatedproductsbyWarehouse":false,"VAT":10,"AllowChangePrice":true,"AllowChangeSalespeople":false,"LimitTransactionTime":false,"StockControlWhenSelling":false,"AllowPrintPreview":true,"CostMethod":0,"ReturnHistory":true,"ChangeTimer":true,"NotAllowUpdateOrder":365,"ElectronicWeightScaleCodeLength":6,"BlockOfTimeToUseService":6,"PRP80DPI":203,"A4DPI":600,"PRPKitchen80DPI":203,"ReceiptPrinterName":"","KitchenAPrinterName":"","KitchenBPrinterName":"","KitchenCPrinterName":"","KitchenDPrinterName":"","BartenderAPrinterName":"","BartenderBPrinterName":"","BartenderCPrinterName":"","BartenderDPrinterName":"","BarCodePrinterName":"","PoleDisplay":"","PoleDisplayBaudRate":9600,"QrCodeEnable":false,"MerchantCode":"","MerchantName":""};
    config.value('posSettings',settings);



    var privileges = {
    admin : true,
    rights: {
    }
    };
    config.value('privileges', privileges);
    //save current session to localstorage
    //we will re-load in in case of offline salescreen
    if (window.localStorage) {
    try{
    localStorage.setItem('pos_printerserver', printerServer);
    if(privileges){
    localStorage.setItem('pos_privileges', JSON.stringify(privileges));
    }
    if(settings){
    localStorage.setItem('pos_settings', JSON.stringify(settings));
    }
    localStorage.setItem('pos_session', JSON.stringify(session));
    }catch (err) {}
    }

    })();



