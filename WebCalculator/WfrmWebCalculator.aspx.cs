using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace WebCalculator
{
    public partial class WfrmWebCalculator : System.Web.UI.Page
    {
        string strInput = "0";  //輸入字串暫存
        string strOutput = "";  //輸出字串暫存
        protected void Page_Load(object sender, EventArgs e)
        {
            if (null != Session["strInput"])
            {
                strInput = (string)Session["strInput"];
            }
            if (null != Session["strOutput"])
            {
                strOutput = (string)Session["strOutput"];
            }
            Session["strInput"] = strInput;
            Session["strOutput"] = strOutput;
            txtDisplay.Text = strOutput + Environment.NewLine + strInput;   //中間換行
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "0";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "0";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "1";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "1";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "2";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "2";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "3";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "3";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "4";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "4";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "5";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "5";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "6";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "6";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "7";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "7";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "8";
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "8";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            if (0 == Check())
            {
                strInput = "9";                
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += "9";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btnDot_Click(object sender, EventArgs e)
        {
            if (1 == Check() || 2 == Check() || 3 == Check() || 4 == Check())
            {
                strInput = (string)Session["strInput"];
                strInput += "0.";
            }
            else if (7 == Check())
            {
                //甚麼都不做
            }
            else
            {
                strInput = (string)Session["strInput"];
                strInput += ".";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = Session["strOutput"] + Environment.NewLine + strInput;
        }

        protected void btnAddition_Click(object sender, EventArgs e)
        {
            strOutput = (string)Session["strOutput"];

            if (1 == Check() || 2 == Check() || 3 == Check() || 4 == Check())
            {
                strInput = (string)Session["strInput"];
                strInput = strInput.Substring(0, strInput.Length - 1) + "+";                             
            }
            else
            {
                strOutput += strInput;
                Session["strOutput"] = strOutput;
                strInput = "+";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = strOutput + Environment.NewLine + strInput;
        }

        protected void btnSubtraction_Click(object sender, EventArgs e)
        {
            strOutput = (string)Session["strOutput"];

            if (1 == Check() || 2 == Check() || 3 == Check() || 4 == Check())
            {
                strInput = (string)Session["strInput"];
                strInput = strInput.Substring(0, strInput.Length - 1) + "-";
            }
            else
            {
                strOutput += strInput;
                Session["strOutput"] = strOutput;
                strInput = "-";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = strOutput + Environment.NewLine + strInput;
        }

        protected void btnMultiplication_Click(object sender, EventArgs e)
        {
            strOutput = (string)Session["strOutput"];

            if (1 == Check() || 2 == Check() || 3 == Check() || 4 == Check())
            {
                strInput = (string)Session["strInput"];
                strInput = strInput.Substring(0, strInput.Length - 1) + "*";
            }
            else
            {
                strOutput += strInput;
                Session["strOutput"] = strOutput;
                strInput = "*";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = strOutput + Environment.NewLine + strInput;
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            strOutput = (string)Session["strOutput"];

            if (1 == Check() || 2 == Check() || 3 == Check() || 4 == Check())
            {
                strInput = (string)Session["strInput"];
                strInput = strInput.Substring(0, strInput.Length - 1) + "/";
            }
            else
            {
                strOutput += strInput;
                Session["strOutput"] = strOutput;
                strInput = "/";
            }
            Session["strInput"] = strInput;
            txtDisplay.Text = strOutput + Environment.NewLine + strInput;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void btnBackspace_Click(object sender, EventArgs e)
        {
            strInput = (string)Session["strInput"];
            strOutput = (string)Session["strOutput"];

            if (0 != strInput.Length)
            {
                //若strInput不是空的                
                strInput = strInput.Substring(0, strInput.Length - 1);
                Session["strInput"] = strInput;
            }
            else if (0 != strOutput.Length)
            {
                //若strOutput不是空的
                strInput = strOutput.Substring(0, strOutput.Length - 1);
                Session["strInput"] = strInput;
                strOutput = "";
                Session["strOutput"] = strOutput;
            }
            txtDisplay.Text = strOutput + Environment.NewLine + strInput;
            //若strInput跟strOutput都是空的，就甚麼都不做
        }

        protected void btnAmount_Click(object sender, EventArgs e)
        {
            strInput = (string)Session["strInput"];
            strOutput = (string)Session["strOutput"];

            if (1 == Check() || 2 == Check() || 3 == Check() || 4 == Check() || 7 == Check())
            {
                //若最後輸入的是+-*/.就直接捨去
                strInput = strInput.Substring(0, strInput.Length - 1);
            }

            strOutput += strInput;
            ToPostFix(strOutput);
        }

        //判斷輸入字串
        private int Check()
        {
            try
            {
                strInput = (string)Session["strInput"];

                if ("0".Equals(strInput))
                {
                    return 0;
                }
                else if (strInput.EndsWith("+"))
                {
                    return 1;
                }
                else if (strInput.EndsWith("-"))
                {
                    return 2;
                }
                else if (strInput.EndsWith("*"))
                {
                    return 3;
                }
                else if (strInput.EndsWith("/"))
                {
                    return 4;
                }
                else if (strInput.Contains("."))
                {
                    return 7;
                }
            }
            catch (Exception e)
            {
                strInput = "0";
                strOutput = "";
                txtDisplay.Text = strInput;
            }
            return -1;

        }

        //將輸入的運算字串轉成後序式
        private void ToPostFix(string strOutput)
        {
            List<string> alPostFix = new List<string>(); //後序式字串陣列
            string opAS = "";    //+-號暫存器
            string opMD = "";    //*/號暫存器
            string strTemp = "";

            for (int i = 0; i < strOutput.Length; i++)
            {
                if ("*".Equals(strOutput.ElementAt(i).ToString()) || "/".Equals(strOutput.ElementAt(i).ToString()))
                {
                    if ("" != opMD)
                    {
                        alPostFix.Add(strTemp);
                        strTemp = "";
                        alPostFix.Add(opMD);
                        opMD = strOutput.ElementAt(i).ToString();
                    }
                    else
                    {
                        alPostFix.Add(strTemp);
                        strTemp = "";
                        opMD = strOutput.ElementAt(i).ToString();
                    }
                }
                else if ("+".Equals(strOutput.ElementAt(i).ToString()) || "-".Equals(strOutput.ElementAt(i).ToString()))
                {
                    if ("" != opAS && "" != opMD)
                    {
                        alPostFix.Add(strTemp);
                        strTemp = "";
                        alPostFix.Add(opMD);
                        alPostFix.Add(opAS);
                        opMD = "";
                        opAS = strOutput.ElementAt(i).ToString();
                    }
                    else if ("" != opAS && "" == opMD)
                    {
                        alPostFix.Add(strTemp);
                        strTemp = "";
                        alPostFix.Add(opAS);
                        opAS = strOutput.ElementAt(i).ToString();
                    }
                    else if ("" == opAS && "" != opMD)
                    {
                        alPostFix.Add(strTemp);
                        strTemp = "";
                        alPostFix.Add(opMD);
                        opMD = "";
                        opAS = strOutput.ElementAt(i).ToString();
                    }
                    else
                    {
                        alPostFix.Add(strTemp);
                        strTemp = "";
                        opAS = strOutput.ElementAt(i).ToString();
                    }
                }
                else
                {
                    strTemp += strOutput.ElementAt(i).ToString();
                }
            }
            //將for迴圈裡剩下的暫存器add進alPostFix
            if ("" != strTemp)
            {
                alPostFix.Add(strTemp);
            }
            if ("" != opMD)
            {
                alPostFix.Add(opMD);
            }
            if ("" != opAS)
            {
                alPostFix.Add(opAS);
            }

            //debug用
            //string s = "";
            //foreach (string a in alPostFix)
            //{
            //    s += " " + a;
            //}

            Computer(alPostFix);
        }

        //使用堆疊將後序式進行計算
        private void Computer(List<string> alPostFix)
        {
            Stack<string> staNum = new Stack<string>();   //建立數字用堆疊
            double num1 = 0;
            double num2 = 0;

            try
            {
                //逐一取出，若數字就壓入堆疊，若運算子就從堆疊取出2個數字做運算，運算完再壓入堆疊。
                foreach (string s in alPostFix)
                {
                    switch (s)
                    {
                        case "+":
                            {
                                if (0 != staNum.Count)
                                {
                                    num1 = double.Parse(staNum.Pop());    //pop()從堆疊頂取出元素，並將其從堆疊移除
                                }
                                if (0 != staNum.Count)
                                {
                                    num2 = double.Parse(staNum.Pop());    //peek()從堆疊頂取出元素，但並不移除
                                }
                                staNum.Push((num2 + num1).ToString());
                                break;
                            }
                        case "-":
                            {
                                if (0 != staNum.Count)
                                {
                                    num1 = double.Parse(staNum.Pop());
                                }
                                if (0 != staNum.Count)
                                {
                                    num2 = double.Parse(staNum.Pop());
                                }
                                staNum.Push((num2 - num1).ToString());
                                break;
                            }
                        case "*":
                            {
                                if (0 != staNum.Count)
                                {
                                    num1 = double.Parse(staNum.Pop());
                                }
                                if (0 != staNum.Count)
                                {
                                    num2 = double.Parse(staNum.Pop());
                                }
                                staNum.Push((num2 * num1).ToString());
                                break;
                            }
                        case "/":
                            {
                                if (0 != staNum.Count)
                                {
                                    num1 = double.Parse(staNum.Pop());
                                    if (0 == num1)
                                    {
                                        throw new ArithmeticException();
                                    }
                                }
                                if (0 != staNum.Count)
                                {
                                    num2 = double.Parse(staNum.Pop());
                                }
                                staNum.Push((num2 / num1).ToString());
                                break;
                            }
                        default:
                            {
                                staNum.Push(s);
                                break;
                            }
                    }                    
                }
                strOutput = "";
                strInput = staNum.Peek();   //堆疊頂的元素即為運算式的解
                txtDisplay.Text = strInput;
            }
            catch (Exception e)
            {
                //輸入錯誤的運算式或超出運算範圍
                Response.Write("輸入錯誤的運算式或超出運算範圍");
                clear();
            };

            Session["strInput"] = strInput;
            Session["strOutput"] = strOutput;
        }

        private void clear()
        {
            strOutput = "";
            Session["strOutput"] = strOutput;
            strInput = "0";
            Session["strInput"] = strInput;
            txtDisplay.Text = strInput;
        }

    }
}