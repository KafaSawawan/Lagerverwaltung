function createTopArticlesChart(articleLabels, articleQuantities) {
    const ctx = document.getElementById('artikelChart').getContext('2d');

    // Überprüfen, ob das Diagramm bereits existiert und zerstören, falls notwendig
    if (window.artikelChart && typeof window.artikelChart.destroy === 'function') {
        window.artikelChart.destroy();
    }

    // Neues Diagramm erstellen
    window.artikelChart = new Chart(ctx, {
        type: 'bar', // Typ des Diagramms (z. B. 'pie', 'bar', etc.)
        data: {
            labels: articleLabels, // Artikel-Namen
            datasets: [{
                label: 'Artikelmenge',
                data: articleQuantities, // Artikel-Mengen
                backgroundColor: [
                    '#FF6384', '#36A2EB', '#FFCE56', '#4BC0C0', '#9966FF'
                ],
                borderColor: '#fff',
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    display: false // Keine Legende für Balkendiagramme
                },
                tooltip: {
                    callbacks: {
                        label: function (context) {
                            return `${context.label}: ${context.raw}`;
                        }
                    }
                }
            },
            scales: {
                y: {
                    beginAtZero: true,
                    title: {
                        display: true,
                        text: 'Menge'
                    }
                },
                x: {
                    title: {
                        display: true,
                        text: 'Artikel'
                    }
                }
            }
        }
    });
}
