-- A query a seguir leva em consideração que um mesmo produto pode ter duas ou mais cores,
-- de acordo com a tabela dada de exemplo.

-- Nesse caso, optei por agregar todo o valor do produto em uma mesma linha, ao invés de uma
-- duplicação com valores diferentes para cada cor.

SELECT NOME_PROD,
       PRC_TOTAL,
       PRC_TOTAL + (PRC_TOTAL * 0.1) AS PRC_ACRES,
       PRC_TOTAL - (PRC_TOTAL * 0.1) AS PRC_DESC,
       CORES
FROM (SELECT p.NOME_PROD                                                  AS NOME_PROD,
             COALESCE(p.PRC_PROD, 0) + COALESCE(SUM(c.PRC_COR), 0)        AS PRC_TOTAL,
             GROUP_CONCAT(COALESCE(c.NOME_COR, 'Nenhuma') SEPARATOR ', ') AS CORES
      FROM PRODUTOS AS p
               LEFT JOIN CORES AS c ON c.IDPRODUTO = p.IDPRODUTO
      WHERE p.NOME_PROD IS NOT NULL
      GROUP BY p.IDPRODUTO, p.NOME_PROD, p.PRC_PROD
      ORDER BY PRC_TOTAL) AS subquery;