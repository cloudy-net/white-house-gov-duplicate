const esbuild = require('esbuild');
const path = require('path');
const sass = require('node-sass');

const sassPlugin = {
    name: 'sass',
    setup(build) {
        build.onLoad({ filter: /\.scss$/ }, async (args) => {
            const filePath = path.relative(process.cwd(), args.path);
            const result = sass.renderSync({
                file: filePath,
            });
            console.log(filePath)
            return {
                loader: 'css',
                contents: result.css.toString(),
                watchDirs: [],
            };
        });
    },
};

const _root = 'wwwroot';
const entryPoints = ['scripts/index.js', 'styles/index.scss'].map((entry) => path.resolve(__dirname,`${_root}/src/${entry}`));

esbuild.build(
    {
        logLevel: "info",
        entryPoints: entryPoints,
        bundle: true,
        splitting: true,
        format: 'esm',
        outdir: `${_root}/dist/`,
        sourcemap: true,
        plugins: [sassPlugin],
        minify: true,
        watch: true,
    }).catch((e) => console.error(e.message));