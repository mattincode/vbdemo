import {HttpClient} from "aurelia-http-client";

export class VbEdit {
    constructor() {
        this.bookings = "";
    }

    activate() {
        this.http = new HttpClient();
        return this.http.get("api/bookings").then(response => {
            this.bookings = response.content;
        });
    }
}