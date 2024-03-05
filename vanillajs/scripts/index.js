import {acceptTermsOfUse} from "./termsOfUse.js";
import {renderImageToCanvas} from "./imageCanvas.js";

const dataSource = "http://188.166.203.164";

const getJsonData = async () => {
    const response = await fetch(`${dataSource}/static/test.json`);
    if (response.status === 200) {
        return response.json();
    } else {
        return {};
    }
};

(async () => {
    const data = await getJsonData();
    
    await acceptTermsOfUse(data.terms_of_use);

    //im not sure that this is good way to hide/show these html elements, but because of usage modular script
    //(I mean its mechanics of execution after rendering the DOM) and because of requirement that content must be 
    //displayed after accepting terms of use, i decided to do it this way(there are many 
    //variations on how this can be done, but i hope my implementation isnt the worth :) )
    document.querySelector(".image-gallery").classList.add("is-visible");

    for (let image of data.images) {
        await renderImageToCanvas(`${dataSource}${image.image_url}`);
    }
})();
