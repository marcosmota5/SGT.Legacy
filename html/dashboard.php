<?php 
    /* Database connection settings */
    $host = '192.168.0.119';
    $user = 'eurolift_services';
    $pass = 'p2YwcnxOMVEgSMRw';
    $db = 'db_eurolift_sgt';
    $mysqli = new mysqli($host,$user,$pass,$db) or die($mysqli->error);

    $data1 = '';
    $data2 = '';

    //query to get data from the table
    $sql = 'SELECT COUNT(DISTINCT(prop.id_proposta)) AS Quantidade_Enviada, CONCAT(DATE_FORMAT(prop.data_solicitacao, '%m'), '-', 
    LEFT(CONCAT(UCase(Left(MONTHNAME(prop.data_solicitacao), 1)), LCase(SUBSTRING(MONTHNAME(prop.data_solicitacao), 2))), 3)) AS Mes FROM tb_propostas AS prop LEFT JOIN tb_itens_propostas AS itpr ON prop.id_proposta=itpr.id_proposta LEFT JOIN tb_usuarios AS usua ON prop.id_usuario_insercao=usua.id_usuario GROUP BY Mes ORDER BY Mes';
    $result = mysqli_query($mysqli, $sql);

    //loop through the returned data
    while ($row = mysqli_fetch_array($result)) {
        $data1 = $data1 . ''
    }


?>