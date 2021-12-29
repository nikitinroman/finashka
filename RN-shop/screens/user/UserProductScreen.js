import React from "react";
import {FlatList, Button, Alert, View, Text, StyleSheet} from "react-native";
import {useSelector, useDispatch} from "react-redux";
import {HeaderButtons, Item} from "react-navigation-header-buttons";

import HeaderButton from "../../components/UI/HeaderButton";
import ProductItem from "../../components/shop/ProductItem";
import Colors from "../../constants/Colors";
import * as productsActions from "../../store/actions/products";

const UserProductScreen = (props) => {
    const userProducts = useSelector((state) => state.products.userProducts);
    const dispatch = useDispatch();

    const editProductHandler = (id) => {
        props.navigation.navigate("EditProduct", {productId: id});
    };

    const deleteHandler = (id) => {
        Alert.alert("Are you sure?", "Do you really want to delete this item?", [
            {text: "No", style: "default"},
            {
                text: "Yes",
                style: "destructive",
                onPress: () => {
                    dispatch(productsActions.deleteProduct(id));
                },
            },
        ]);
    };

    if (userProducts.length === 0) {
        return (
            <View style={styles.centered}>
                <Text>No products found. Start creating some!</Text>
            </View>
        );
    }

    return (
        <FlatList
            data={userProducts}
            keyExtractor={(item) => item.id}
            renderItem={(itemData) => (
                <ProductItem
                    image={itemData.item.imageUrl}
                    title={itemData.item.title}
                    price={itemData.item.price}
                    onSelect={() => {
                        editProductHandler(itemData.item.id);
                    }}
                >
                    <Button
                        color={Colors.primary}
                        title="Изменить"
                        onPress={() => {
                            editProductHandler(itemData.item.id);
                        }}
                    />
                    <Button
                        color={Colors.primary}
                        title="Удалить"
                        onPress={deleteHandler.bind(this, itemData.item.id)}
                    />
                </ProductItem>
            )}
        />
    );
};

UserProductScreen.navigationOptions = (navData) => {
    return {
        headerTitle: "Ваши товары",
        headerLeft: () => (
            <HeaderButtons HeaderButtonComponent={HeaderButton}>
                <Item
                    title="Меню"
                    iconName="md-menu"
                    onPress={() => {
                        navData.navigation.toggleDrawer();
                    }}
                />
            </HeaderButtons>
        ),
        headerRight: () => (
            <HeaderButtons HeaderButtonComponent={HeaderButton}>
                <Item
                    title="Добавить"
                    iconName="md-create"
                    onPress={() => {
                        navData.navigation.navigate("EditProduct");
                    }}
                />
            </HeaderButtons>
        ),
    };
};

const styles = StyleSheet.create({
    centered: {
        flex: 1,
        justifyContent: "center",
        alignItems: "center",
    },
});

export default UserProductScreen;
