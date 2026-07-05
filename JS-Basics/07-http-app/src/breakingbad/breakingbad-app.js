/**
 * 
 * @returns { Promise<Object>}
 */
const fetchQuote = async () => {

    const res = await fetch(`https://api.breakingbadquotes.xyz/v1/quotes`);
    const data = await res.json();

    return data;
}

/**
 * 
 * @param {HTMLDivElement} element 
 */
export const BreakingBadApp = async (element) => {

    element.innerHTML = 'Loading...';

    const quoteLabel = document.createElement('blockquote');
    const authoLabel = document.createElement('h3');
    const nextQuoteButton = document.createElement('button');
    nextQuoteButton.innerText = 'Next Quote';

    const renderQuote = (data) => {


        quoteLabel.innerHTML = data[0].quote;
        authoLabel.innerHTML = data[0].author;
        element.replaceChildren(quoteLabel, authoLabel, nextQuoteButton);

    }

    nextQuoteButton.addEventListener('click', async () => {

        element.innerHTML = 'Loading...';
        const quote = await fetchQuote();
        renderQuote(quote)
    });

    fetchQuote()
        .then(renderQuote);

}