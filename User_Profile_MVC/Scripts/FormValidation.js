$(function () {
    function addError(inputField, errorMessage) {
        inputField.addClass('invalid');
        inputField.next('.ValidationError').html(errorMessage);
    }

    function removeError(inputField) {
        inputField.removeClass('invalid');
        inputField.next('.ValidationError').html('');
    }

    $(".AvatarCreate").submit(function (event) {
        var isValid = true;
        var NameInput = $(this).children('input[name=Name]');
        var UrlInput = $(this).children('input[name=Url]');

        //Validate the name.
        if (NameInput.val() == '') {
            addError(NameInput, "Name cannot be empty");
            isValid = false;
        }
        else if (NameInput.val().length > 16) {
            addError(NameInput, "Name cannot exceed 16 characters.");
            isValid = false;
        }
        else {
            removeError(NameInput);
        }

        //Validate the url.
        if (UrlInput.val() == '') {
            addError(UrlInput, "Url cannot be empty");
            isValid = false;
        }
        else if (UrlInput.val().length > 1024) {
            addError(UrlInput, "Url cannot exceed 1024 characters.");
            isValid = false;
        }
        else {
            removeError(UrlInput);
        }

        event.preventDefault();
        return false;
    });

    $('.AvatarCreate > input[name=Name]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val() == '') {
                addError($(this), "Name cannot be empty");
            }
            else if ($(this).val().length > 16) {
                addError($(this), "Name cannot exceed 16 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });

    $('.AvatarCreate > input[name=Url]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val() == '') {
                addError($(this), "Url cannot be empty");
            }
            else if ($(this).val().length > 1024) {
                addError($(this), "Url cannot exceed 1024 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });

    $(".AvatarUpdate").submit(function (event) {
        var isValid = true;
        var NameInput = $(this).children('input[name=Name]');
        var UrlInput = $(this).children('input[name=Url]');

        //Validate the name.
        if (NameInput.val().length > 16) {
            addError(NameInput, "Name cannot exceed 16 characters.");
            isValid = false;
        }
        else {
            removeError(NameInput);
        }

        //Validate the url.
        if (UrlInput.val().length > 1024) {
            addError(UrlInput, "Url cannot exceed 1024 characters.");
            isValid = false;
        }
        else {
            removeError(UrlInput);
        }

        event.preventDefault();
        return false;
    });

    $('.AvatarUpdate > input[name=Name]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val().length > 16) {
                addError($(this), "Name cannot exceed 16 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });

    $('.AvatarCreate > input[name=Url]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val().length > 1024) {
                addError($(this), "Url cannot exceed 1024 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });

    $(".UserProfileCreate").submit(function (event) {
        var isValid = true;
        var Short_AliasInput = $(this).children('input[name=Short_Alias]');
        var Long_AliasInput = $(this).children('input[name=Long_Alias]');

        //Validate the short alias.
        if (Short_AliasInput.val() == '') {
            addError(Short_AliasInput, "Short alias cannot be empty.");
            isValid = false;
        }
        else if (Short_AliasInput.val().length > 4) {
            addError(Short_AliasInput, "Short alias cannot exceed 4 characters.");
            isValid = false;
        }
        else {
            removeError(Short_AliasInput);
        }

        //Validate the long alias.
        if (Long_AliasInput.val() == '') {
            addError(Long_AliasInput, "Long alias cannot be empty.");
            isValid = false;
        }
        else if (Long_AliasInput.val().length > 32) {
            addError(Long_AliasInput, "Long alias cannot exceed 32 characters.");
            isValid = false;
        }
        else {
            removeError(Long_AliasInput);
        }

        //event.preventDefault();
        //return false;
    });

    $('.UserProfileCreate > input[name=Short_Alias]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val() == '') {
                addError($(this), "Short alias cannot be empty.");
            }
            else if ($(this).val().length > 4) {
                addError($(this), "Short alias cannot exceed 4 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });

    $('.UserProfileCreate > input[name=Long_Alias]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val() == '') {
                addError($(this), "Long alias cannot be empty.");
            }
            else if ($(this).val().length > 32) {
                addError($(this), "Long alias cannot exceed 32 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });

    $(".UserProfileUpdate").submit(function (event) {
        var isValid = true;
        var Short_AliasInput = $(this).children('input[name=Short_Alias]');
        var Long_AliasInput = $(this).children('input[name=Long_Alias]');

        //Validate the short alias.
        if (Short_AliasInput.val().length > 4) {
            addError(Short_AliasInput, "Short alias cannot exceed 4 characters.");
            isValid = false;
        }
        else {
            removeError(Short_AliasInput);
        }

        //Validate the long alias.
        if (Long_AliasInput.val().length > 32) {
            addError(Long_AliasInput, "Long alias cannot exceed 32 characters.");
            isValid = false;
        }
        else {
            removeError(Long_AliasInput);
        }

        event.preventDefault();
        return false;
    });

    $('.UserProfileUpdate > input[name=Short_Alias]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val().length > 4) {
                addError($(this), "Short alias cannot exceed 4 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });

    $('.UserProfileUpdate > input[name=Long_Alias]').on('input', function () {
        //If an invalid field is changed, its validility is reexamined.
        if ($(this).hasClass('invalid')) {
            if ($(this).val().length > 32) {
                addError($(this), "Long alias cannot exceed 32 characters.");
            }
            else {
                removeError($(this));
            }
        }
    });
});