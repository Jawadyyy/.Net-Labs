function getQueryParam(param) {
    const urlParams = new URLSearchParams(window.location.search);
    return urlParams.get(param);
}

document.getElementById('resume-name').innerText = getQueryParam('name');
document.getElementById('resume-email').innerText = getQueryParam('email');
document.getElementById('resume-phone').innerText = getQueryParam('phone');
document.getElementById('resume-address').innerText = getQueryParam('address');
document.getElementById('resume-degree').innerText = getQueryParam('degree');
document.getElementById('resume-institution').innerText = getQueryParam('institution');
document.getElementById('resume-grad-year').innerText = getQueryParam('grad-year');
document.getElementById('resume-job-title').innerText = getQueryParam('job-title');
document.getElementById('resume-company').innerText = getQueryParam('company');
document.getElementById('resume-duration').innerText = getQueryParam('duration');
document.getElementById('resume-responsibilities').innerText = getQueryParam('responsibilities');
document.getElementById('resume-skills').innerText = getQueryParam('skills');
document.getElementById('resume-certifications').innerText = getQueryParam('certifications');
document.getElementById('resume-references').innerText = getQueryParam('references');