export const acceptTermsOfUse = async (termsOfUse) => {
    
    return new Promise((resolve, reject) => {
    
        const modalContainer = document.querySelector(".modal-container");

        termsOfUse.paragraphs.sort((a, b) => a.index - b.index);
        termsOfUse.paragraphs.forEach(paragraph => {
            const paragraphContainer = document.createElement("div");
            paragraphContainer.className = "paragraph-container";
            
            const paragraphHeader = document.createElement("h3");
            paragraphHeader.className = "paragraph-header";
            paragraphHeader.innerText = `${paragraph.index}. ${paragraph.title}`;
            paragraphContainer.appendChild(paragraphHeader);
    
            const paragraphContent = document.createElement("p");
            paragraphContent.innerText = paragraph.content ? paragraph.content : paragraph.text;
            paragraphContainer.appendChild(paragraphContent);
    
            modalContainer.appendChild(paragraphContainer);
        });

        document.querySelector(".accept-btn").addEventListener("click", () => {
            document.querySelector(".modal-dialog.is-visible").classList.remove("is-visible");
            resolve();
        });
    });
}
