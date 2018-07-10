using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prjWebApi.Class
{
    public class SendFlexMessage
    {
        public static List<FlexType> Send()
        {
            List<Bubble> TemplateContent = new List<Bubble>
            {
                //GBubble()是自己定義的方法，回傳可以組成數量價格的樣板LIST<T>
                GBubble1(),
                GBubble2()
            };

            var FlexMessage = new Carousel()
            {
                type = "carousel",
                contents = TemplateContent
            };


            List<FlexType> _FlexType = new List<FlexType>();
            _FlexType.Add(new FlexType()
            {
                type = "flex",
                altText = "This is a Flex Message QQ",
                contents = FlexMessage
            });

            return _FlexType;
        }

        public static Bubble GBubble1()
        {
            List<BodyContents> _BodyContents = new List<BodyContents>();
            _BodyContents.Add(new Head()
            {
                type = "text",
                text = "REQUIRE",
                weight = "bold",
                color = "#1DB446",
                size = "sm"
            });
            _BodyContents.Add(new Title()
            {
                type = "text",
                text = "飲品",
                weight = "bold",
                size = "xxl",
                margin = "md"
            });
            _BodyContents.Add(new SendLocation()
            {
                type = "text",
                text = "南門市場",
                color = "#aaaaaa",
                size = "xs",
                margin = "xs",
                wrap = true
            });
            //加入產品列表表頭
            List<AreaBoxContents> _AreaBox1Content = new List<AreaBoxContents>();
            _AreaBox1Content.Add(new ProductNameTitle()
            {
                type = "text",
                text = "品項",
                size = "sm",
                color = "#555555"
            });
            _AreaBox1Content.Add(new ProductQuantityTitle()
            {
                type = "text",
                text = "數量(單位)",
                size = "sm",
                color = "#111111",
                align = "end"
            });

            _BodyContents.Add(new AreaBox1()
            {
                type = "box",
                layout = "horizontal",
                margin = "xl",
                contents = _AreaBox1Content
            });

            _BodyContents.Add(new Separator()
            {
                type = "separator",
                margin = "xs"
            });
            //加入產品明細(DATA)
            List<ProductDetailsList> _PDListContent = new List<ProductDetailsList>();
            _PDListContent.Add(new ProductName()
            {
                type = "text",
                text = "Engergy Drink",
                size = "sm",
                color = "#555555"
            });
            _PDListContent.Add(new ProductQuantity()
            {
                type = "text",
                text = "600(ml)",
                size = "sm",
                color = "#111111",
                align = "end"
            });

            List<AreaBoxContents> _PDBoxContent = new List<AreaBoxContents>();
            _PDBoxContent.Add(new ProductListBox()
            {
                type = "box",
                layout = "horizontal",
                contents = _PDListContent
            });

            _BodyContents.Add(new ProductDetailsBox()
            {
                type = "box",
                margin = "xl",
                layout = "vertical",
                spacing = "sm",
                contents = _PDBoxContent
            });

            //分隔線
            _BodyContents.Add(new Separator()
            {
                type = "separator",
                margin = "xxl"
            });

            //加入總數統計BOX(Data)
            List<AreaBoxContents> _PDTotalContent = new List<AreaBoxContents>();
            _PDTotalContent.Add(new TotalQuantityTitle()
            {
                type = "text",
                text = "總數",
                size = "sm",
                color = "#555555"
            });
            _PDTotalContent.Add(new TotalQuantity()
            {
                type = "text",
                text = "3",
                size = "sm",
                color = "#111111",
                align = "end"
            });

            _BodyContents.Add(new AreaBox1()
            {
                type = "box",
                layout = "horizontal",
                margin = "xxl",
                contents = _PDTotalContent
            });
            //分隔線
            _BodyContents.Add(new Separator()
            {
                type = "separator",
                margin = "xxl"
            });

            //加入採購員使用BTN(DATA)

            List<AreaBoxContents> _BTNContent = new List<AreaBoxContents>();
            _BTNContent.Add(new PurchaserButtonContents()
            {
                type = "button",
                style = "primary",
                color = "#aaaaaa",
                action = new ButtonAction
                {
                    type = "uri",
                    label = "採購員B",
                    uri = "line://app/1587126793-kPKy05Gj",
                }
            });

            _BodyContents.Add(new PurchaserButtonBox()
            {
                type = "box",
                margin = "md",
                layout = "horizontal",
                contents = _BTNContent
            });


            //需求單整體Style
            var BubbleStyles = new BubbleStyle
            {
                footer = new footer
                {
                    separator = true
                }
            };
            var _Body = new Body
            {
                type = "box",
                layout = "vertical",
                contents = _BodyContents
            };

            var BubbleList = new Bubble()
            {
                type = "bubble",
                styles = BubbleStyles,
                body = _Body
            };

            return BubbleList;
        }
     public static Bubble GBubble2()
        {
            List<BodyContents> _BodyContents = new List<BodyContents>();
            _BodyContents.Add(new Head()
            {
                type = "text",
                text = "REQUIRE",
                weight = "bold",
                color = "#1DB446",
                size = "sm"
            });
            _BodyContents.Add(new Title()
            {
                type = "text",
                text = "魚類品項",
                weight = "bold",
                size = "xxl",
                margin = "md"
            });
            _BodyContents.Add(new SendLocation()
            {
                type = "text",
                text = "八斗子漁市",
                color = "#aaaaaa",
                size = "xs",
                margin = "xs",
                wrap = true
            });
            //加入產品列表表頭
            List<AreaBoxContents> _AreaBox1Content = new List<AreaBoxContents>();
            _AreaBox1Content.Add(new ProductNameTitle()
            {
                type = "text",
                text = "品項",
                size = "sm",
                color = "#555555"
            });
            _AreaBox1Content.Add(new ProductQuantityTitle()
            {
                type = "text",
                text = "數量(單位)",
                size = "sm",
                color = "#111111",
                align = "end"
            });

            _BodyContents.Add(new AreaBox1()
            {
                type = "box",
                layout = "horizontal",
                margin = "xl",
                contents = _AreaBox1Content
            });

            _BodyContents.Add(new Separator()
            {
                type = "separator",
                margin = "xs"
            });
            //加入產品明細(DATA)
            List<ProductDetailsList> _PDListContent = new List<ProductDetailsList>();
            _PDListContent.Add(new ProductName()
            {
                type = "text",
                text = "黑鯛",
                size = "sm",
                color = "#555555"
            });
            _PDListContent.Add(new ProductQuantity()
            {
                type = "text",
                text = "12(kg)",
                size = "sm",
                color = "#111111",
                align = "end"
            });
            List<ProductDetailsList> _PDListContent2 = new List<ProductDetailsList>();
            _PDListContent2.Add(new ProductName()
            {
                type = "text",
                text = "金目鱸",
                size = "sm",
                color = "#555555"
            });
            _PDListContent2.Add(new ProductQuantity()
            {
                type = "text",
                text = "45(kg)",
                size = "sm",
                color = "#111111",
                align = "end"
            });
            List<AreaBoxContents> _PDBoxContent = new List<AreaBoxContents>();
            _PDBoxContent.Add(new ProductListBox()
            {
                type = "box",
                layout = "horizontal",
                contents = _PDListContent
            });
            _PDBoxContent.Add(new ProductListBox()
            {
                type = "box",
                layout = "horizontal",
                contents = _PDListContent2
            });


            _BodyContents.Add(new ProductDetailsBox()
            {
                type = "box",
                margin = "xl",
                layout = "vertical",
                spacing = "sm",
                contents = _PDBoxContent
            });
            

            //分隔線
            _BodyContents.Add(new Separator()
            {
                type = "separator",
                margin = "xxl"
            });

            //加入總數統計BOX(Data)
            List<AreaBoxContents> _PDTotalContent = new List<AreaBoxContents>();
            _PDTotalContent.Add(new TotalQuantityTitle()
            {
                type = "text",
                text = "總共",
                size = "sm",
                color = "#555555"
            });
            _PDTotalContent.Add(new TotalQuantity()
            {
                type = "text",
                text = "57(kg)",
                size = "sm",
                color = "#111111",
                align = "end"
            });

            _BodyContents.Add(new AreaBox1()
            {
                type = "box",
                layout = "horizontal",
                margin = "xxl",
                contents = _PDTotalContent
            });
            //分隔線
            _BodyContents.Add(new Separator()
            {
                type = "separator",
                margin = "xxl"
            });

            //加入採購員使用BTN(DATA)
            List<AreaBoxContents> _BTNContent = new List<AreaBoxContents>();
            _BTNContent.Add(new PurchaserButtonContents()
            {
                type = "button",
                style = "primary",
                color = "#aaaaaa",
                action = new ButtonAction
                {
                    type = "uri",
                    label = "採購員A",
                    uri = "line://app/1587126793-kPKy05Gj",
                }
            });

            _BodyContents.Add(new PurchaserButtonBox()
            {
                type = "box",
                margin = "md",
                layout = "horizontal",
                contents = _BTNContent
            });


            //需求單整體Style
            var BubbleStyles = new BubbleStyle
            {
                footer = new footer
                {
                    separator = true
                }
            };
            var _Body = new Body
            {
                type = "box",
                layout = "vertical",
                contents = _BodyContents
            };

            var BubbleList = new Bubble()
            {
                type = "bubble",
                styles = BubbleStyles,
                body = _Body
            };

            return BubbleList;
        }
    }

    public class PushMessage
    {
        public string to { get; set; }
        public List<FlexType> message { get; set; }
    }

    public class FlexType
    {
        public string type { get; set; }
        public string altText { get; set; }
        public Carousel contents { get; set; }
    }

    public class Carousel
    {
        public string type { get; set; }
        public List<Bubble> contents { get; set; }
    }
    public class Bubble
    {
        public string type { get; set; }
        public BubbleStyle styles { get; set; }
        public Body body { get; set; }
    }

    public class BubbleStyle
    {
        public footer footer { get; set; }
    }
    public class footer
    {
        public bool separator { get; set; }
    }

    public class Body
    {
        public string type { get; set; }
        public string layout { get; set; }
        public List<BodyContents> contents { get; set; }
    }
    public abstract class BodyContents
    {
        public string type { get; set; }
    }

    public class Head : BodyContents
    {
        public string text { get; set; }
        public string weight { get; set; }
        public string color { get; set; }
        public string size { get; set; }
    }
    public class Title : BodyContents
    {
        public string text { get; set; }
        public string weight { get; set; }
        public string size { get; set; }
        public string margin { get; set; }
    }
    public class SendLocation : BodyContents
    {
        public string text { get; set; }
        public string size { get; set; }
        public string margin { get; set; }
        public string color { get; set; }
        public bool wrap { get; set; }
    }
    
    public class AreaBox1 : BodyContents
    {
        public string text { get; set; }
        public string layout { get; set; }
        public string margin { get; set; }
        public List<AreaBoxContents> contents { get; set; }
    }

    public abstract class AreaBoxContents
    {
        public string type { get; set; }
    }

    public class ProductNameTitle : AreaBoxContents
    {
        public string text { get; set; }
        public string size { get; set; }
        public string color { get; set; }
    }

    public class ProductQuantityTitle : AreaBoxContents
    {
        public string text { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string align { get; set; }
    }
    public class Separator : BodyContents
    {
        public string margin { get; set; }
    }
    public class ProductDetailsBox : BodyContents
    {
        public string margin { get; set; }
        public string layout { get; set; }
        public string spacing { get; set; }
        public List<AreaBoxContents> contents { get; set; }
    }
    public class ProductListBox : AreaBoxContents
    {
        public string layout { get; set; }
        public List<ProductDetailsList> contents { get; set; }
    }
    public abstract class ProductDetailsList
    {
        public string type { get; set; }
    }
    public class ProductName : ProductDetailsList
    {
        public string text { get; set; }
        public string size { get; set; }
        public string color { get; set; }
    }
    public class ProductQuantity : ProductDetailsList
    {
        public string text { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string align { get; set; }
    }
    public class ProductTotalQuantityBox : BodyContents
    {
        public string margin { get; set; }
        public string layout { get; set; }
        public List<AreaBoxContents> contents { get; set; }
    }

    public class TotalQuantityTitle : AreaBoxContents
    {
        public string text { get; set; }
        public string size { get; set; }
        public string color { get; set; }
    }

    public class TotalQuantity : AreaBoxContents
    {
        public string text { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string align { get; set; }
    }
    public class PurchaserButtonBox : BodyContents
    {
        public string margin { get; set; }
        public string layout { get; set; }
        public List<AreaBoxContents> contents { get; set; }
    }
    public class PurchaserButtonContents : AreaBoxContents
    {
        public string style { get; set; }
        public string color { get; set; }
        public ButtonAction action { get; set; }
    }
    public class ButtonAction
    {
        public string type { get; set; }
        public string label { get; set; }
        public string uri { get; set; }
    }
}