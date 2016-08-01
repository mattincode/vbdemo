import {HttpClient} from "aurelia-http-client";
// import {inject} from "aurelia-framework";

export class App {
    constructor() {
        this.message = "Hello from Aurelia";
    }

    activate() {
        this.http = new HttpClient();
        return this.http.get("api/bookings").then(response => {
            this.message = response.content;
        });
    }
}

