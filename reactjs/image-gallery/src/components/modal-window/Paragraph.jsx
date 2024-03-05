import React from "react";

export const Pharagraph = ({data}) => {
    return (
        <div className="paragraph-container">
            <h3 className="paragraph-header">{`${data.index}. ${data.title}`}</h3>
            <p>{data.content ? data.content : data.text}</p>
        </div>
    )
}