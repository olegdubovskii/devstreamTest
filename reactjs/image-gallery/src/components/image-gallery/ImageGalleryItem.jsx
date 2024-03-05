import React, { useEffect, useRef } from "react";

export const ImageItem = ({ data }) => {

    const canvasRef = useRef();

    const onClickHandle = (e) => {
        const aElement = document.createElement("a");
        aElement.href = canvasRef.current.toDataURL("image/png");
        aElement.download = data.slice(data.lastIndexOf("/") + 1);
        aElement.click();
    }

    useEffect(() => {
        if (data) {
            const image = new Image();
            const canvasContext = canvasRef.current.getContext("2d");
            image.crossOrigin = "anonymous";
            image.src = data;
            image.onload = () => {
                canvasRef.current.width = image.width;
                canvasRef.current.height = image.height;
                canvasContext.drawImage(image, 0, 0);
            };
        }
    }, []);

    return (
        <div className="image-gallery-element">
            <canvas className="image-gallery-element-canvas" ref={canvasRef} />
            <button onClick={onClickHandle} className="image-gallery-element-button">Save image</button>
        </div>
    )
}