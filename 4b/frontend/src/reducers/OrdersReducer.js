const initialState = [];

export default (state = initialState, action) => {
    switch (action.type) {
        case 'ADD_ORDER':
            state.push({
                id: action.id,
                stock: action.stock
            });
            return state;
        default:
            return state;
    }
}
