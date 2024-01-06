<script lang="ts">
    export let number: number;
    export let title: string;
    export let content: string;
    export let img: string;
    export let outlet: string;
</script>
<div class="frame">
    <div class="canvas">
        <div class="image-container">
            <img src={img} alt="">
        </div>
        <div class="title"><h3>{title}</h3></div>
        <div class="text">{content}</div>
    </div>
</div>

<style lang="scss">
    .canvas{
        
        width: 100%;
        height: 100%;
        position: relative;

        .image-container{
            border-radius: 5%;
            width: 100%;
            height: 100%;
            overflow: hidden;

            img{
                width: 100%;
                height: 100%;
                object-fit: cover;
                object-position: 50% 50%;
                cursor: pointer;
                transition: .5s ease-in-out;
            }
        }

        .text{
            opacity: 0;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            transition: .3s ease-in-out;
        }

        .title{
            display: grid;
            place-items: center;
            position: absolute;
            color: white;
            top: 80%;
            background-color: rgba(0, 0, 0, 0.386);
            min-width: 100%;
            height: 20%;
            transition: .3s ease-out;
            

            h3{
                position: absolute;
                margin-left: 2%;
                overflow: hidden;
                max-width: inherit;
                word-spacing: 3px;
                min-height: inherit;
                // border: solid 2px red;
                
            }

        }
    }

    .canvas:hover{
        img{
            transform: scale(1.5);
            opacity: 0.3;
        }

        .text{
            opacity: 1;
            
        }

        .title{
            
            opacity: 0;
        }
    }

    @for $i from 1 through 6 {
        .w-#{$i} {
            grid-column: span #{$i}
        }
    }


</style>