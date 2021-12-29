import React from "react";
import {createStackNavigator} from "react-navigation-stack";
import {createAppContainer, createSwitchNavigator} from "react-navigation";
import {createDrawerNavigator, DrawerItems} from "react-navigation-drawer";
import {useDispatch} from "react-redux";

import {Platform, SafeAreaView, Button, View} from "react-native";
import {Ionicons} from "@expo/vector-icons";
import ProductsOverviewScreen from "../screens/shop/ProductsOverviewScreen";
import ProductDetailScreen from "../screens/shop/ProductDetailScreen";
import CartScreen from "../screens/shop/CartScreen";
import OrdersScreen from "../screens/shop/OrdersScreen";
import UserProductScreen from "../screens/user/UserProductScreen";
import EditProductScreen from "../screens/user/EditProductScreen";
import StartupScreen from "../screens/StartupScreen";
import AuthScreen from "../screens/user/AuthScreen";
import Colors from "../constants/Colors";
import * as authActions from "../store/actions/auth";

const defaultNavOptions = {
    headerStyle: {
        backgroundColor: Platform.OS === "android" ? Colors.primary : "",
    },
    headerTitleStyle: {
        fontFamily: "open-sans-bold",
    },
    headerBackTitleStyle: {
        fontFamily: "open-sans",
    },
    headerTintColor: Platform.OS === "android" ? "white" : Colors.primary,
};

const ProductsNavigator = createStackNavigator(
    {
        ProductsOverview: ProductsOverviewScreen,
        ProductDetail: ProductDetailScreen,
        Cart: CartScreen,
    },
    {
        navigationOptions: {
            drawerIcon: (drawerConfig) => (
                <Ionicons name="md-cart" size={23} color={drawerConfig.tintColor}/>
            ),
        },
        defaultNavigationOptions: defaultNavOptions,
    }
);

const OrdersNavigator = createStackNavigator(
    {
        Orders: OrdersScreen,
    },
    {
        navigationOptions: {
            drawerIcon: (drawerConfig) => (
                <Ionicons name="md-list" size={23} color={drawerConfig.tintColor}/>
            ),
        },
        defaultNavigationOptions: defaultNavOptions,
    }
);

const AdminNavigator = createStackNavigator(
    {
        UserProducts: UserProductScreen,
        EditProduct: EditProductScreen,
    },
    {
        navigationOptions: {
            drawerIcon: (drawerConfig) => (
                <Ionicons name="md-create" size={23} color={drawerConfig.tintColor}/>
            ),
        },
        defaultNavigationOptions: defaultNavOptions,
    }
);

const ShopNavigator = createDrawerNavigator(
    {
        Товары: ProductsNavigator,
        Заказы: OrdersNavigator,
        Администрирование: AdminNavigator,
    },
    {
        contentOptions: {
            activeTintColor: Colors.primary,
            itemsContainerStyle: {
                marginVertical: 15,
            },
            labelStyle: {
                fontFamily: "open-sans",
            },
        },
        contentComponent: (props) => {
            const dispatch = useDispatch();
            return (
                <View style={{flex: 1, paddingTop: 20}}>
                    <SafeAreaView forceInset={{top: "always", horizontal: "never"}}>
                        <DrawerItems {...props} />
                        <Button
                            title="Logout"
                            color={Colors.primary}
                            onPress={() => {
                                dispatch(authActions.logout());
                                // props.navigation.navigate("Auth");
                            }}
                        />
                    </SafeAreaView>
                </View>
            );
        },
    }
);

const AuthNavigator = createStackNavigator(
    {
        Auth: AuthScreen,
    },
    {
        defaultNavigationOptions: defaultNavOptions,
    }
);

const MainNavigator = createSwitchNavigator({
    Startup: StartupScreen,
    Auth: AuthNavigator,
    Shop: ShopNavigator,
});

export default createAppContainer(MainNavigator);
