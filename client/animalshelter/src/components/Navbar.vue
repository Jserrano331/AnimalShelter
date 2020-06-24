<template>
  <nav>
    <v-navigation-drawer
      v-model="drawer"
      app
      right
    >
      <v-list dense>
        <v-list-item link>
          <v-list-item-action>
            <v-icon>mdi-home</v-icon>
          </v-list-item-action>

          <v-list-item-content>
            <v-list-item-title>Home</v-list-item-title>
          </v-list-item-content>
        </v-list-item>

        <v-list-item link>
          <v-list-item-action>
            <v-icon>mdi-email</v-icon>
          </v-list-item-action>

          <v-list-item-content>
            <v-list-item-title>Contact</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar
      app
      color="cyan lighten-2"
      dark
    >
          <v-toolbar-title><v-btn>
          <v-icon medium left>mdi-paw</v-icon>
          <span>Animal Shelter</span>
        </v-btn></v-toolbar-title>
      <v-spacer></v-spacer>



      <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
    </v-app-bar>

  </nav>
</template>

<script>
export default {
    name: 'Navbar',
    data: () => ({
      drawer: false,
    }),
};
</script>