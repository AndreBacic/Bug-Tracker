﻿
function translucentCoverOnClick(t) {
    t.style.display = "none"
    for (m of menus) {
        m.style.display = "none"
    }
    for (a of arrows) {
        a.style.transform = "rotateZ(-90deg)"
    }
}
