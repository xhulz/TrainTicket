import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from "@angular/common/http";
import { Observable } from "rxjs";
import { Injectable, Injector } from "@angular/core";

@Injectable()
export class Interceptor implements HttpInterceptor {

    constructor(private injector: Injector) {}

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const authRequest = request.clone({
            setHeaders:{'Content-Type': 'application/json'}
        })
           
        return next.handle(authRequest)
    }

}