function sendRequest(t) {
    $.ajax({
        url: '/api/students',
        data: { turn: parseInt(t) },
        method: 'get',
        beforeSend: function () {
            $('#moreDiv #progressbar').css('display', 'block');
            $('#moreDiv #moreButton').css('display', 'none');
        }, 
        complete: function () {
            $('#moreDiv #progressbar').css('display', 'none');
            $('#moreDiv #moreButton').css('display', 'block');
        }
    })
        .done(function (d) {
            //because we load 24 domains per each request and if less than 24 means domains ended.
            if (d.length < 24)
                $('#moreDiv').remove();

            var i = 1;
            var element;
            for (var item in d) {
                if (i % 4 == 1)
                    element = $('<div class="row mt-2"></div>').appendTo('#appendingPlaceholder');
                var str = '<div class="col-md-3 col-sm-6 mb-2"><div class="card '
                switch (i % 8) {
                    case 0: str += 'bg-dark text-light'; break;
                    case 1: str += 'bg-primary text-light'; break;
                    case 2: str += 'bg-success text-light'; break;
                    case 3: str += 'bg-warning text-light'; break;
                    case 4: str += 'bg-light text-dark'; break;
                    case 5: str += 'bg-danger text-light'; break;
                    case 6: str += 'bg-secondary text-light'; break;
                    case 7: str += 'bg-info text-light'; break;
                }
                str += ' text-center h-100 domain-card" ><img class="card-img-top" src="/images/DomainsCard/' + d[item].imageName + '"><div class="card-body"><h5 class="card-title">';
                str += d[item].gender ? '<i class="fa fa-male align-middle"></i> آقای ' : '<i class="fa fa-female align-middle"></i> خانم ';
                str += d[item].firstName + ' ' + d[item].lastName;
                str += '</h5><p class="card-text"><i class="fa fa-book-open align-middle"></i> دوره : ' + d[item].course + '<br><br>';
                str += '<a href="' + d[item].siteUrl + '" class="badge badge-warning" target="_blank"><i class="fa fa-globe align-middle"></i> مشاهده سایت  </a></p></div></div></div>';
                $(element).append(str);
                i++;
            }
        });
}
