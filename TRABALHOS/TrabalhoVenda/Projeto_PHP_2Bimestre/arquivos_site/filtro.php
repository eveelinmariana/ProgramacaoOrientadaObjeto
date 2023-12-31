<section class="cl_filtro">
    <form class="justify-content-center justify-content-md-start" method="GET" action="">
        <!--faz alinhamento  -->

        <div class="input-group input-group-sm"><!-- BUSCA  -->
            <input type="text" class="form-control" placeholder="Digite aqui o que procura" name="pesquisa">
            <button class="btn btn-danger" name="buscar">
                Buscar
            </button>
            <a class="btn btn-secondary" href="cardapio.php">Limpar</a>
        </div>
    </form>
</section>
<?php
// Verificar se o botão de busca foi clicado
if (isset($_GET['buscar'])) {
    // Verificar se o campo de pesquisa está preenchido
    if (isset($_GET['pesquisa']) && !empty($_GET['pesquisa'])) {
        $pesquisa = $_GET['pesquisa'];

        // Conectar ao banco de dados
        $conn;
        if (!$conn) {
            die('Erro ao conectar ao banco de dados: ' . mysqli_connect_error());
        }

        // Preparar a consulta SQL para buscar registros que correspondem à pesquisa
        $sql = "SELECT * FROM produto WHERE nome LIKE '%$pesquisa%'";

        // Executar a consulta SQL  
        $result = mysqli_query($conn, $sql);
        if (!$result) {
            die('Erro na consulta: ' . mysqli_error($conn));
        }


        mysqli_close($conn);
    }

?>

    <br />
    <section class="container_card">

        <div class="row text-center">
            <?php
            if (mysqli_num_rows($result) > 0) { ?>

                <?php
                while ($row = mysqli_fetch_assoc($result)) {

                    if ($row['promo'] > 0) {
                        $preco =  $row['preco'] - ($row['preco'] * 0.05);
                    } else {

                        $preco = $row['preco'];
                    }

                ?>
                    <div class="card text-center m-2" style="width: 16rem; height: 410px;">
                        <form action="carrinho.php" method="post">

                            <strong class="card-text1"><?= $row['nome'] ?></strong>
                            <input type="hidden" name="cod" value="<?= $row['codigo'] ?>">
                            <input type="hidden" name="preco" value="<?= $row['preco'] ?>">
                            <input type="hidden" name="nomeprod" value="<?= $row['nome'] ?>">
                            <img src="<?= $row['image_url'] ?>" class="img_card2" alt="...">

                            <div class="text-descr"><?= substr($row['descricao'], 0, 40) ?></div>
                            <div class="cor-preco">

                                R$ <?= number_format($preco, 2, ',', '.') ?>

                                <span class="cor-promo"> <?= $row['promo'] > 0 ? ' &nbsp;&nbsp; Promoção' : '' ?></span>
                            </div>
                                <div style="margin-top: 5px;">

                                    Quantidade: <input type="number" name="qtd" class="tm_input" min="1" value="1" />
                                    <input type="submit" name="addcarrinho" id="addcarrinho" class="btn btn-success" value="Adicionar ao Carrinho" />
                                </div>
                        </form>
                    </div>
            <?php }
            } else {
                echo '<p class="text-center"><h3>Produto não encontrado.</h3></p>';
            } ?>
        </div>

    </section>

<?php } ?>

<section class="cl_filtro">

    <!--////////////////////////////////////////////////////////////////////////////////  -->
    <form class="ml-3 d-inline-block " method="GET">
        <br />
        <select class="form-select form-select-sm" name="categoria" onchange="this.form.submit()">
            <option value="">Selecione a categoria</option>
            <?php

            // Consulta para obter as categorias disponíveis
            $sql1 = "SELECT tipo_cod, tipo_nome FROM Tipo_produto";
            $resultado = $conn->query($sql1);

            // Exibição das opções da lista suspensa com as categorias
            if ($resultado->num_rows > 0) {
                while ($row = $resultado->fetch_assoc()) { ?>

            <?php
                    $tipoCod = $row["tipo_cod"];
                    $tipoNome = $row["tipo_nome"];
                    echo "<option value='$tipoCod'>$tipoNome</option>";
                }
            }
            ?>
        </select>
    </form>

    <!--  -->
</section>
<?php
// Verificar se uma categoria foi selecionada
if (isset($_GET["categoria"]) && !empty($_GET["categoria"])) {
    $categoria = $_GET["categoria"];



    // Consulta para obter os produtos da categoria selecionada
    $sql1 = "SELECT * FROM Produto WHERE tipo_cod = '$categoria'";
    $result = $conn->query($sql1);
    // Exibição dos resultados da pesquisa
?>
    <section class="container_card">

        <?php if ($result->num_rows > 0) { ?>
            <div class="row text-center">
                <div class="text">
                    <h4 class="text-center">resultados</h4>
                </div>

                <?php
                while ($row = $result->fetch_assoc()) {

                    if ($row['promo'] > 0) {
                        $preco =  $row['preco'] - ($row['preco'] * 0.05);
                    } else {

                        $preco = $row['preco'];
                    }

                ?>
                    <div class="card m-2" style="width: 16rem;height: 410px;">
                        <form action="carrinho.php" method="post">
                            <strong class="card-text1"><?= $row['nome'] ?></strong>
                            <input type="hidden" name="cod" value="<?= $row['codigo'] ?>">
                            <input type="hidden" name="preco" value="<?= $row['preco'] ?>">
                            <input type="hidden" name="nomeprod" value="<?= $row['nome'] ?>">
                            <img src="<?= $row['image_url'] ?>" class="img_card2" alt="...">
                            <div class="text-descr"><?= substr($row['descricao'], 0, 40) ?></div>
                            <div class="cor-preco">

                                R$ <?= number_format($preco, 2, ',', '.') ?>

                                <span class="cor-promo"> <?= $row['promo'] > 0 ? ' &nbsp;&nbsp; Promoção' : '' ?></span>
                            </div>
                            <div style="margin-top: 5px;">

                                Quantidade: <input type="number" name="qtd" class="tm_input" min="1" value="1" /> <br />
                                <input type="submit" name="addcarrinho" id="addcarrinho" class="btn btn-success" value="Adicionar ao Carrinho" />
                            </div>
                        </form>
                    </div>
                <?php }
                ?>

            </div>
    <?php
        } else {

            echo '<p class="text-center"><h3>Produto não encontrado.</h3></p>';
        }


        $conn->close();
    }

    ?>


    </section>