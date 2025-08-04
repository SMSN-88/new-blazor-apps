export function setDarkModeClass(isDarkMode) {
    if (isDarkMode) {
        document.body.classList.add('dark-mode');
    }
    else {
        document.body.classList.remove('dark-mode');
    }
}