/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace TOY.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('TOY');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}