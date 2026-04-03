window.downloadPageAsPdf = async function (elementId, filename) {
    const { jsPDF } = window.jspdf;

    const element = document.getElementById(elementId);
    if (!element) {
        console.error("Element not found: " + elementId);
        return;
    }

    const canvas = await html2canvas(element, { scale: 2 });
    const imgData = canvas.toDataURL("image/png");

    const pdf = new jsPDF("p", "mm", "a4");
    const pageWidth = pdf.internal.pageSize.getWidth();
    const imgHeight = (canvas.height * pageWidth) / canvas.width;

    pdf.addImage(imgData, "PNG", 0, 0, pageWidth, imgHeight);
    pdf.save(filename);
};
