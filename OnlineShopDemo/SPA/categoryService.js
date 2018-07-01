


app.service('categoryService', function ($http) {

    // get all

    // add category
    this.addCategory = function (category) {

        var response = $http({

            method: 'post',
            url: 'Category/AddCategory',
            data: JSON.stringify(category),
            dataType : "json"
        });

        return response;
    }

    // update
    this.updateCategory = function (category) {
        var response = $http({
            method: 'post',
            url: 'Category/UpdateCategory',
            data: JSON.stringify(category),
            dataType: "json"

        });

        return response;
    }

    // delete category
    this.deleteCategory = function (id) {
        var response = $http({
            method: "post",
            url: "Category/DeleteCategory",
            params: {
                parentID: JSON.stringify(id)
            }
        });
    }
});