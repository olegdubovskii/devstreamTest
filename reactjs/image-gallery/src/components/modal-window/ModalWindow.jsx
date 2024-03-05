import React from "react";
import "./styles/modal-window.css";
import { Pharagraph } from "./Paragraph";

export const ModalWindow = ({paragraphs, setShow}) => {

    return (
        <div className="modal-dialog">
            <h2 className="modal-header">Terms of Use</h2>
            <div className="modal-container">
                {paragraphs?.map((item) => {
                    return <Pharagraph key={item.index} data={item}/>
                })}
            </div>
            <button className="accept-btn" onClick={() => setShow(false) }>Accept</button>
        </div>
    )
}