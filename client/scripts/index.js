console.log("hi")

const essays = [
  {
      name: "My First Essay",
      date: "2024-04-21",
      description: "This is the description of my first essay.",
       content: "<p>Luke J Morrell Marx Essay <br>HY 102<br> 2/15/2022<br> How the Bourgeoisie Creates its own Gravediggers? <br>(Please Make Me the Tsar of Russia)<br><br> In Marxs critique of the capitalist system in The Communist Manifesto, it is stated that “What the bourgeoisie therefore produces, above all, are its own grave-diggers. Its fall and the victory of the proletariat are equally inevitable”. What is clearly meant by Marx in this writing is that the system or bourgeois industrialism will be dismantled by the fruit from which the tree bears.<br><br> What fruits did the bourgeois system of industrialization then bear? With the industrial system, innovation created new products, cheaper products, and more markets to which sell the products. With this system, the need for constant innovation arises, nearing the inevitable reality, according to Marx, that all new goods will have been already made and every market to which they may be sold have been exhausted. At the point of exhaustion, the system of bourgeois industrialism will cease to be functional, and societal collapse and restructure will take place.<br><br> A capitalist’s sole mission is to maximize profit, only ceasing to act further on his aim when the consequences of his path may make it disadvantageous. Therefore, they exploit the labor of the workers (while continuingly lowering wages and thus increasing the exploitation) while supporting political and social reforms to the benefit of the workers according to Marx. It is a system built on constant need for innovation and exploitation, without either aspect the system deteriorates into ash. As new innovations, such as the railroad, steamship, and telegraph, are made that seemingly make the world smaller, it becomes far easier for the far and near flung workers of the world to unite under a common identity: proletariat. As concessions made to the workers by the capitalists, (attempts to keep the worker on the side of the capitalist, against the side of other capitalists) especially education and political education, class consciousness will inevitably rise.<br><br> Marx envisions the final revolution, that of the proletariat rising against the bourgeoisie, as being a “violent overthrow of the bourgeoisie”.</p>"
    },
  {
      name: "My Second Essay",
      date: "2024-04-22",
      description: "This is the description of my second essay.",
      content:"<p>12</p>"
  },

];

function handleOnLoad() {
  displayEssayTable(essays);
}

function displayEssayTable(essaysData) {
  let html = `
  <h1>My Essays</h1>
  <table class="table table-striped">
      <thead>
          <tr>
              <th>Name</th>
              <th>Date</th>
              <th>Description</th>
              <th>Action</th>
          </tr>
      </thead>
      <tbody>`;

  essaysData.forEach(essay => {
      html += `
      <tr>
          <td>${essay.name}</td>
          <td>${essay.date}</td>
          <td>${essay.description}</td>
          <td><button class="btn btn-primary" onclick="openEssayPage('${essay.name}', '${essay.date}', '${essay.description}', '${essay.content}')">Read More</button></td>
      </tr>`;
  });

  html += `
      </tbody>
  </table>`;

  document.getElementById('app').innerHTML = html;
}


function openEssayPage(name, date, description, content) {
  const url = `essay.html?name=${encodeURIComponent(name)}&date=${encodeURIComponent(date)}&description=${encodeURIComponent(description)}&content=${encodeURIComponent(content)}`;
  window.open(url, '_blank');
}



