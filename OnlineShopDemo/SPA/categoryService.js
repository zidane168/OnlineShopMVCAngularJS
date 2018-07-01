


app.service('categoryService', function ($http) {

    // get all

    // add category
    this.addCategory = function (category) {
        debugger;
        var data2 = JSON.stringify(category);
        var response = $http({

            method: 'post',
            url: window.location.protocol + "//" + window.location.hostname + ":" + window.location.port + '/api/CategoryAPI/AddCategory',           
            data: JSON.stringify(category),
            dataType : "json"
        });

        return response;
        debugger;
    }

    // update
    this.updateCategory = function (category) {
        var response = $http({
            method: 'post',
            url: window.location.protocol + "//" + window.location.hostname + ":" + window.location.port + '/api/Category/UpdateCategory',
            data: JSON.stringify(category),
            dataType: "json"

        });

        return response;
    }

    // delete category
    this.deleteCategory = function (id) {
        var response = $http({
            method: "post",
            url: window.location.protocol + "//" + window.location.hostname + ":" + window.location.port + '/api/Category/DeleteCategory',
            params: {
                parentID: JSON.stringify(id)
            }
        });
    }
});