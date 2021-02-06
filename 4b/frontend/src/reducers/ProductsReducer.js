const initialState = [
    {
        id: 1,
        name: 'Brompton',
        merk: 'Brompton',
        price: 10000000,
        stock: 5,
    },
    {
        id: 2,
        name: 'Titanium X',
        merk: 'Titanium',
        price: 13000000,
        stock: 2,
    },
    {
        id: 3,
        name: 'Family A',
        merk: 'Family',
        price: 6000000,
        stock: 7,
    },
    {
        id: 4,
        name: 'S Flat',
        merk: 'Wingcyle',
        price: 11000000,
        stock: 10,
    },
    {
        id: 5,
        name: 'Magnetic',
        merk: 'Wingcyle',
        price: 11000000,
        stock: 0,
    },
];

export default (state = initialState, type) => {
    switch (type) {
        default:
            return state;
    }
}
