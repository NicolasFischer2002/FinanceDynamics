
window.downloadFileFromBase64 = (base64, filename, contentType) => {
    const link = document.createElement('a');
    link.href = `data:${contentType};base64,${base64}`;
    link.download = filename || 'download';
    document.body.appendChild(link);
    link.click();
    link.remove();
};