function answer(str) {
    var probaA = $("#probaA").val();
    var probaB = $("#probaB").val();
    combine(str, probaA, probaB, function (res) {
        $(".answer").text(res);
    });
}

function displayAlert(str) {
    $(".alert-message").text(str);
    $(".alert").show();
}

function hideAlert() {
    $(".alert").hide();
}

function combine(type, probaA, probaB, done) {
    $.ajax({
        url: '/api/Calculator/' + type,
        type: 'GET',
        data: {
            probaA: probaA,
            probaB: probaB
        },
        dataType: 'json',
        success: function (data) {
            hideAlert();
            done(data);
        },
        error: function (jqXHR, exception) {
            displayAlert(jqXHR.responseJSON.Message);
            done("");
        }
    });
}

$("#combine-independent-event").click(function () {
    answer("GetIndependentJointProbability");
});
$("#combine-not-mutually-exclusive-event").click(function () {
    answer("GetNotMutuallyExclusiveJointProbability");
});
