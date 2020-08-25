import * as ReactDOM from "react-dom";
import "./styles/main.tsx";
import { Routes } from "./config/routes/index";

ReactDOM.render(
    new Routes().generate(),
    document.getElementById("root") as HTMLElement
);
