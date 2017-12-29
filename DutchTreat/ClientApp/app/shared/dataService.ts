import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Product } from "./product";
import { Order, OrderItem } from "./order";
import { Injectable } from "@angular/core";
import 'rxjs/add/operator/map';

@Injectable()
export class DataService {

    constructor(private http: HttpClient) { }

    public order: Order;
    public products: Product[] = [];


    loadProducts(): Observable<boolean> {
        return this.http.get("/api/products")
            .map((data: any[]) => {
                this.products = data;
                return true;
            });
    }

    public AddToOrder(product: Product) {

        if (!this.order) {
            this.order = new Order();
        }

        let item: OrderItem;

        item = new OrderItem();
        item.productId = product.id;
        item.productArtist = product.artist;
        item.productCategory = product.category;
        item.productArtId = product.artId;
        item.productTitle = product.title;
        item.productSize = product.size;
        item.unitPrice = product.price;
        item.quantity = 1;

        this.order.items.push(item);
    }
}