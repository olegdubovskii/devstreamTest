
export const renderImageToCanvas = async (imageUrl) => {
    return new Promise((resolve, reject) => {
        const imageGalleryContainer = document.querySelector(".image-gallery-container");

        const imageGalleryElement = document.createElement("div");
        imageGalleryElement.className = "image-gallery-element";

        const imageCanvas = document.createElement("canvas");
        imageCanvas.className = "image-gallery-element-canvas";
        const canvasContext = imageCanvas.getContext("2d");

        const image = new Image();
        image.crossOrigin = "anonymous";
        image.src = imageUrl;
        image.onload = () => {
            imageCanvas.width = image.width;
            imageCanvas.height = image.height;
            canvasContext.drawImage(image, 0, 0);
        };

        imageGalleryElement.appendChild(imageCanvas);
        
        const imageDownloadButton = document.createElement("button");
        imageDownloadButton.className = "image-gallery-element-button";
        imageDownloadButton.innerText = "Save image";
        imageDownloadButton.addEventListener("click", async () => {
             const aElement = document.createElement("a");
             aElement.href = imageCanvas.toDataURL("image/png");
             aElement.download = imageUrl.slice(imageUrl.lastIndexOf("/") + 1);
             aElement.click();
        });
        imageGalleryElement.appendChild(imageDownloadButton);
    
        imageGalleryContainer.appendChild(imageGalleryElement);
        resolve();
    });
};