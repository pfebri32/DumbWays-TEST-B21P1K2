import { combineReducers } from "redux";

import OrdersReducer from './OrdersReducer';
import ControlReducer from './ControlReducer';
import ProductsReducer from './ProductsReducer';

const RootReducer = combineReducers({
    control: ControlReducer,
    orders: OrdersReducer,
    products: ProductsReducer,
});

export default RootReducer;