# Abroad
Веб-приложение 
Техническое задание для разработки онлайн платформы для единой базы данных по гражданам КР за рубежом

Граждане КР за рубежом

Цель – осуществление своевременного учета и отслеживания количества граждан Кыргызской Республики, обучающихся в высших учебных заведениях иностранных государств.

Информирование выезжающих на обучение граждан о необходимости прохождения регистрации и предоставления данных будет следующим образом, в зависимости от категории выезжающих за рубеж:

- граждане, выезжающие на обучение по линии межправительственных и межведомственных соглашений, будут информироваться непосредственно Министерством (Отделом международного сотрудничества и привлечения инвестиций). В связи с тем, что отбор и направление за рубеж этой категории граждан осуществляется через Министерство, мы располагаем списками и контактными данными по этим гражданам. Для выезда на обучение они будут заключать с Министерством соответствующий договор, в который можно внести пункт об обязательной регистрации в единой базе данных.

- граждане, выезжающие на обучение по программам академического обмена и по линии межвузовских соглашений, будут информироваться направляющим их учебным заведением. В связи с тем, что эти граждане являются студентами вузов КР, и направляются на обучение по их линии, вузы располагают информацией о количестве студентов и их контактными данными.

- граждане, выезжающие на обучение в частном порядке - основная сложность разработки эффективного механизма сбора данных заключается в том, что Министерство не обладает информацией об их количестве и странах обучения, не говоря уже о контактных данных для поддержания связи.

Граждане, выезжающие в частном порядке, зачастую отказываются проходить регистрацию даже в загранучреждениях Кыргызской Республике, находящихся в странах пребывания, и не предоставляют никакой информации о своем выезде в МОН КР. В настоящее время у Министерства нет никаких механизмов по установлению связи с данной категорией граждан.

База данных: технические моменты

Доступ к вводу и изменению данных: 
для граждан – ограниченный, только к своим данным, через личный кабинет. 
для вузов – ограниченный, только к данным студентов этого вуза, также через кабинет.
для МОН доступ ко всем данным неограниченный.

Все введенные данные должны собираться в одну большую базу данных, с возможностью выгрузки данных в табличной форме в Excel (форму можно еще обсудить) при необходимости.

Нужно обязательно предусмотреть возможность сортировки данных по маркерам, например, по полу либо стране обучения, либо году поступления.

Также, хорошим бонусом для граждан, регистрирующихся в системе, может быть возможность быстрой обратной связь с администратором (МОН) из личного кабинета, через всплывающую форму «укажите вопрос, укажите свой емайл». Вопросы от граждан могут автоматически перенаправляться на специальную электронную посту Отдела международного сотрудничества и привлечения инвестиций.

Маркеры для ввода данных
•	Ф.И.О.
•	Дата рождения
•	Пол
•	Предыдущее образование (название школы, название высшего учебного заведения)
•	Страна обучения
•	Название учебного заведения
•	Год поступления
•	Программы образования (бакалавриат, магистратура, докторантура, языковая стажировка, летняя школа, стажировка, академическая мобильность – при выборе этого варианта автоматически всплывает пустое поле, где можно указать срок, другое – указать самому)
•	Специальность
•	Форма обучения (бюджет, либо стипендиальная программа, либо контракт)
•	Статус - обновляется регулярно (зачислен / переведен на следующий курс / академический отпуск / отчислен (с указанием причины)
•	Контактные данные гражданина (номера телефонов, электронный адрес)
•	Контактные данные родителей или членов семьи (ФИО, степень родства, номера телефонов, электронный адрес)
•	Согласие на обработку данных

При вводе данных можно задать функцию, что при оставлении полей пустыми регистрацию завершить будет невозможно. Также, можно было бы задать для полей «электронный адрес» определенный формат (например, name@gmail.com) и для поля «номер телефона» автоматическое распознавание кода страны, чтобы минимизировать риск ошибок или предоставления заведомо ложных сведений.

Маркеры, в свою очередь, тоже можно разделить на «личные данные» и «данные для публичного отображения».
В таком случае, можно открыть часть данных для публичного доступа, например, для размещения на сайте МОН, где все желающие смогли бы ознакомиться с количеством студентов из Кыргызской Республики в иностранных государствах.
