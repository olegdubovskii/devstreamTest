import React from "react";
import { ImageItem } from "./ImageGalleryItem";
import "./styles/image-gallery.css";

export const ImageGallery = ({images, source}) => {
    return (
        <div className="image-gallery">
            <h2 className="image-gallery-header">Image gallery</h2>
            <div className="image-gallery-container">
                {images?.map((item, index) => {
                    return <ImageItem key={index} data={source + item.image_url}/>
                })}
            </div>
        </div>
    )
}