<template>
  <nav>
    <v-navigation-drawer disable-resize-watcher class="hidden-lg-and-up" v-model="drawer" app right>
      <v-list dense>
        <v-list-item 
        link
        v-for="link in navigation"
        :key="link.text"
        @click="$router.push(link.link)"
        >
          <v-list-item-action>
            <v-icon>{{link.icon}}</v-icon>
          </v-list-item-action>

          <v-list-item-content>
            <v-list-item-title>{{link.text  }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>

        <v-spacer></v-spacer>

        <v-list-item link @click="drawer = false">
          <v-list-item-action>
            <v-icon color="red">mdi-close</v-icon>
          </v-list-item-action>

          <v-list-item-content>
            <v-list-item-title>Close</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar app color="blue lighten-2" dark>
      <v-toolbar-title>
        <v-btn @click="$router.push('home')" class="grey darken-4">
          <v-icon medium left>mdi-paw</v-icon>
          <span>Animal Shelter</span>
        </v-btn>
      </v-toolbar-title>

      <v-toolbar-items>
        <v-btn
          class="hidden-md-and-down"
          text
          right
          v-for="link in navigation"
          :key="link.text"
          @click="$router.push(link.link)"
        >
          <v-icon>{{ link.icon }}</v-icon>
          {{ link.text }}
        </v-btn>
      </v-toolbar-items>

      <v-spacer></v-spacer>

      <v-app-bar-nav-icon class="hidden-lg-and-up" @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
    </v-app-bar>
  </nav>
</template>

<script>
export default {
  name: "Navbar",
  data: () => ({
    drawer: false,
    navigation: {
      home: {
        text: "Home",
        link: "home",
        icon: "mdi-home"
      },
      about: {
        text: "About",
        link: "about",
        icon: "mdi-information-outline"
      },
      contact: {
        text: "Contact Us",
        link: "contact",
        icon: "mdi-email"
      }
    }
  })
};
</script>
