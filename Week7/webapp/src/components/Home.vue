<template>
  <div>
    <h1 id="home-heading">Home Page</h1>
    <img src="../assets/llama.jpg" class="llama" />
    <h2>Paragraph 1</h2>
    <p
      class="paragraphs"
    >Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eu enim ut ipsum imperdiet tempus eget non nibh. Praesent tempor non nisi sodales tempus. Curabitur eleifend eros non magna ultricies, a efficitur libero malesuada. Pellentesque consequat nisl a nulla pharetra pharetra. Sed interdum est eu commodo porttitor. Sed sed odio tempus magna ornare luctus. Vestibulum sodales, nibh a fermentum tristique, lorem neque placerat tellus, eu congue elit mi at lectus.</p>
    <h2>Paragraph 2</h2>
    <p
      class="paragraphs"
    >Praesent dui ex, malesuada in ipsum vitae, maximus dictum libero. Sed eu porta metus. Curabitur fermentum quis ipsum vel rutrum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. In quis velit urna. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin egestas, nulla et molestie rhoncus, quam orci facilisis sem, sit amet molestie eros sapien id arcu. Sed semper luctus quam, accumsan ultricies eros interdum sed. Nulla id posuere mauris. Nam laoreet quam placerat, feugiat nisl vitae, hendrerit felis. Integer aliquam tellus in enim dictum consectetur.</p>
    <h2>Paragraph 3</h2>
    <p
      class="paragraphs"
    >Mauris tincidunt lorem odio, nec aliquet felis pellentesque non. Morbi luctus leo condimentum dolor eleifend tincidunt. Aliquam in orci sit amet dolor faucibus vulputate. Curabitur feugiat consectetur ullamcorper. Nam fermentum, tortor non dignissim commodo, ipsum tortor lacinia erat, ac convallis sapien justo laoreet nisl. Nunc elementum vestibulum leo, eget mollis urna ultrices quis. Proin ultricies eros in lectus elementum, non aliquet felis convallis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Vivamus finibus nulla eget vulputate feugiat.</p>
  </div>
</template>

<script>
export default {
  name: "Home"
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#home-heading {
  color: palevioletred;
  font-family: "Times New Roman", Times, serif;
}

p {
  width: 60%;
  background-color: lightcyan;
  font-style: oblique;
}

.llama {
  width: 400px;
  height: 300px;
  border-radius: 10px;
}
</style>
