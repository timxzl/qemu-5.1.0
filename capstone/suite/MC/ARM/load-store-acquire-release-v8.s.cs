# CS_ARCH_ARM, CS_MODE_ARM+CS_MODE_V8, None
0x9f,0x3e,0xd4,0xe1 = ldaexb r3, [r4]
0x9f,0x2e,0xf5,0xe1 = ldaexh r2, [r5]
0x9f,0x1e,0x97,0xe1 = ldaex r1, [r7]
0x9f,0x6e,0xb8,0xe1 = ldaexd r6, r7, [r8]
0x93,0x1e,0xc4,0xe1 = stlexb r1, r3, [r4]
0x92,0x4e,0xe5,0xe1 = stlexh r4, r2, [r5]
0x91,0x2e,0x87,0xe1 = stlex r2, r1, [r7]
0x92,0x6e,0xa8,0xe1 = stlexd r6, r2, r3, [r8]
0x9f,0x5c,0x96,0xe1 = lda r5, [r6]
0x9f,0x5c,0xd6,0xe1 = ldab r5, [r6]
0x9f,0xcc,0xf9,0xe1 = ldah r12, [r9]
0x93,0xfc,0x80,0xe1 = stl r3, [r0]
0x92,0xfc,0xc1,0xe1 = stlb r2, [r1]
0x92,0xfc,0xe3,0xe1 = stlh r2, [r3]
