using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.prob
{
	public class Distribution
	{
		public Func<Real, NonnegativeReal> cumulativeDensityFunction;
		public RealSet domain;
		public Distribution(Func<Real,NonnegativeReal> cumulativeDensityFunction,RealSet domain) {
			this.cumulativeDensityFunction = cumulativeDensityFunction;
			this.domain = domain;
		}
	}


}


/*
 * <!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<!-- saved from url=(0040)http://members.aol.com/johnp71/pdfs.html --><!-- 2003年7月林秀英对原程序进行修改并汉化--

><HTML><HEAD><TITLE>t-分布计算器</TITLE>
<META http-equiv=Content-Type content="text/html; charset=gb2312">
<META http-equiv=PICS-Label 
content='(PICS-1.0 "http://www.classify.org/safesurf/" l on "1996.08.05T10:45+0000 r (SS~~000 1)'>
<SCRIPT language=LiveScript>
<!-- hide this script tag's contents from old browsers

var Pi=Math.PI; var PiD2=Pi/2; var PiD4=Pi/4; var Pi2=2*Pi
var e=2.718281828459045235; var e10 = 1.105170918075647625
var Deg=180/Pi

function Norm(z) {
    z=Math.abs(z)
    var p=1+ z*(0.04986735+ z*(0.02114101+ z*(0.00327763+ z*(0.0000380036+ z*(0.0000488906+ z*0.000005383)))))
    p=p*p; p=p*p; p=p*p
    return 1/(p*p)
    }
function ChiSq(x,n) {
    if(n==1 & x>1000) {return 0}
    if(x>1000 | n>1000) {
        var q=ChiSq((x-n)*(x-n)/(2*n),1)/2
        if(x>n) {return q} {return 1-q}
        }
    var p=Math.exp(-0.5*x); if((n%2)==1) { p=p*Math.sqrt(2*x/Pi) }
    var k=n; while(k>=2) { p=p*x/k; k=k-2 }
    var t=p; var a=n; while(t>0.0000000001*p) { a=a+2; t=t*x/a; p=p+t }
    return 1-p//得右侧概率
    }
function StudT(t,n) {
    t=Math.abs(t); var w=t/Math.sqrt(n); var th=Math.atan(w)
    if(n==1) { return 1-th/PiD2 }
    var sth=Math.sin(th); var cth=Math.cos(th)
    if((n%2)==1)
        { return 1-(th+sth*cth*StatCom(cth*cth,2,n-3,-1))/PiD2 }
        else
        { return 1-sth*StatCom(cth*cth,1,n-3,-1) }
    }
function FishF(f,n1,n2) {
    var x=n2/(n1*f+n2)
    if((n1%2)==0) { return StatCom(1-x,n2,n1+n2-4,n2-2)*Math.pow(x,n2/2) }
    if((n2%2)==0){ return 1-StatCom(x,n1,n1+n2-4,n1-2)*Math.pow(1-x,n1/2) }
    var th=Math.atan(Math.sqrt(n1*f/n2)); var a=th/PiD2; var sth=Math.sin(th); var cth=Math.cos(th)
    if(n2>1) { a=a+sth*cth*StatCom(cth*cth,2,n2-3,-1)/PiD2 }
    if(n1==1) { return 1-a }
    var c=4*StatCom(sth*sth,n2+1,n1+n2-4,n2-2)*sth*Math.pow(cth,n2)/Pi
    if(n2==1) { return 1-a+c/2 }
    var k=2; while(k<=(n2-1)/2) {c=c*k/(k-.5); k=k+1 }
    return 1-a+c
    }
function StatCom(q,i,j,b) {
    var zz=1; var z=zz; var k=i; while(k<=j) { zz=zz*q*k/(k-b); z=z+zz; k=k+2 }
    return z
    }
function ANorm(p) { var v=0.5; var dv=0.5; var z=0
    while(dv>1e-6) { z=1/v-1; dv=dv/2; if(Norm(z)>p) { v=v-dv } else { v=v+dv } }
    return z
    }
function AChiSq(p,n) { var v=0.5; var dv=0.5; var x=0
    while(dv>1e-10) { x=1/v-1; dv=dv/2; if(ChiSq(x,n)>p) { v=v-dv } else { v=v+dv } }
    return x//得右侧分位数
    }
function AStudT(p,n) { var v=0.5; var dv=0.5; var t=0
    while(dv>1e-6) { t=1/v-1; dv=dv/2; if(StudT(t,n)>p) { v=v-dv } else { v=v+dv } }
    return t//得到的t为双侧分位数
    }
function AFishF(p,n1,n2) { var v=0.5; var dv=0.5; var f=0
    while(dv>1e-10) { f=1/v-1; dv=dv/2; if(FishF(f,n1,n2)>p) { v=v-dv } else { v=v+dv } }
    return f
    }
    
//*****  Normal  **********************************************************************

function CalcN(form) {    zz=eval(form.z.value);
                                     var pn1=Fmt(Norm(zz));
                                     pn1=1.0-pn1/2;
                                     pn1=Math.round(100000000*pn1)/100000000;
                                     if(zz>0){    form.pn.value=pn1; }
                                     else{     pn1=1.0-pn1;
                                                pn1=Math.round(100000000*pn1)/100000000;
                                                form.pn.value=pn1;
                                           }
                                 }
function CalcNr(form) {   var pnn=eval(form.pn.value);
                                     if( pnn>=0.5 ){  var pn_=1.0-pnn;
                                                            pn_=pn_*2.0;
                                                            form.z.value=Fmt(ANorm(pn_));
                                                         }
                                     else{  var pn_=pnn*2;
                                             var n_=Fmt(ANorm(pn_));
                                             form.z.value=-n_;
                                           }
                                  }

//*****  t  *****************************************************************************

function CalcT(form) {    tt=eval(form.t.value);
                                    var pt1=Fmt(StudT(tt,eval(form.nt.value)));
                                    pt1=1.0-pt1/2;
                                    pt1=Math.round(100000000*pt1)/100000000;
                                    if( tt>0 ){  form.pt.value=pt1;}
                                    else {    pt1=1.0-pt1;
                                               pt1=Math.round(100000000*pt1)/100000000;
                                               form.pt.value=pt1;
                                           }
                                }
function CalcTr(form) {   var ptt=eval(form.pt.value);
                                     if( ptt>=0.5 ){  var pt_=1-ptt;
                                                        pt_=pt_*2;  
                                                        form.t.value=Fmt(AStudT(pt_,eval(form.nt.value)));
                                                      }
                                     else{   var pt_=ptt*2;
                                              var t_=Fmt(AStudT(pt_,eval(form.nt.value)));
                                              form.t.value=-t_;
                                           }
                                 }
                                 
//*****  chi sqr  ***********************************************************************                            

     
                                 
function CalcX(form) {    var px1=Fmt(ChiSq(eval(form.x.value),eval(form.nx.value)));
                                     form.px.value=1.0-px1;
                                 }
function CalcXr(form) {   var px1=eval(form.px.value);
                                     px1=1.0-px1;  
                                     form.x.value=Fmt(AChiSq(px1,eval(form.nx.value)));
                                  }

//*****  F  ****************************************************************************

function CalcF(form) { form.pf.value=1.0-Fmt(FishF(eval(form.f.value),eval(form.n1.value),eval(form.n2.value))) }

function CalcFr(form) {   var pf1=eval(form.pf.value);
                                     pf1=1-pf1;
                                     form.f.value=Fmt(AFishF(pf1,eval(form.n1.value),eval(form.n2.value)));
                                 }

//**************************************************************************************

function Fmt(x) { 
var v
if(x>=0) { v=''+(x+0.0005) } else { v=''+(x-0.0005) }
return v.substring(0,v.indexOf('.')+4)
}

<!-- done hiding from old browsers -->

function click() 
{
   if (event.button==2) 
   {
      alert("对不起,这里鼠标右键无效!!!");
   } 
}

document.onmousedown=click;

</SCRIPT>

<META content="Microsoft FrontPage 4.0" name=GENERATOR></HEAD>
<BODY bgColor=#06699F topmargin="0" leftmargin="0">

<FORM>
<TABLE height=180 cellSpacing=0 cellPadding=0 width="100%" border=0>
  <TBODY>
  <TR>
    <TD width="100%" height=220>
      <DIV align=left>
      <TABLE height=180 borderColorDark=#666666 width="373" bgColor=#dddddd 
      background="image/hui_di4.png" border=4>
        <TBODY>
        <TR>
          <TD bgColor=#ffffcc colSpan=3 width="514">
            <DIV align=center>
            <P align=left><FONT face=Verdana size=5>&nbsp;&nbsp;<B> 
            </B></FONT><FONT face=Arial size=5>t</FONT><FONT size=5><FONT 
            face=Arial>-</FONT><B>分布的</B></FONT><FONT face=Arial 
            size=5>p</FONT><B><FONT size=5>分位数</FONT></B> </P></DIV>
            <DIV align=center>
            <P 
            align=center>    
            <B><FONT size=5>与分布函数计算器</FONT></B> </P></DIV>
            <DIV align=center>
            <P align=center>&nbsp;&nbsp;&nbsp;<FONT face=Arial> <FONT               
            size=5>F</FONT></FONT><FONT size=5><SUB><FONT 
            face=Arial>t</FONT></SUB>(</FONT><FONT face=Arial><FONT 
            size=5>t</FONT><FONT face=Verdana 
            size=3><SUB>p</SUB></FONT></FONT><FONT size=5>)=</FONT><FONT face=Arial size=5>P{</FONT><FONT size=5> 
            &nbsp;<FONT face=Arial>t</FONT> </FONT><FONT face=宋体               
            size=5>≤</FONT><FONT face=Arial><FONT size=5><B> </B>t</FONT><FONT 
            face=Verdana size=3><SUB>p</SUB></FONT><FONT size=5><B> 
            </B>}=p</FONT></FONT><FONT size=5><B>&nbsp;</B> 
        </FONT></P></DIV></TD></TR>
        <CENTER>
        <TR>
          <TD width="176">
            <DIV align=center><FONT face=Arial size=5>t</FONT><SUB><FONT 
            face=Arial size=3>p</FONT> </SUB></DIV></TD>
          <TD width="170">
            <DIV align=center><FONT face=Arial size=5>n</FONT> </DIV></TD>
          <TD width="156">
            <DIV align=center><FONT face=Arial size=5>p</FONT> </DIV></TD></TR>
        <TR>
          <TD width="176">
            <P align=center><INPUT onfocus=t.select() size=10 value=0 
          name=t></P></TD>
          <TD width="170">
            <P align=center><INPUT onfocus=nt.select() size=10 value=0 
            name=nt></P></TD>
          <TD width="156">
            <P align=center><INPUT onblur=t.focus() onfocus=pt.select() size=10 
            value=0 name=pt></P></TD></TR>
        <TR>
          <TD width="176">
            <P align=center><INPUT onclick=CalcTr(this.form) type=button value="Calc t"></P></TD>
          <TD width="170">　</TD>
          <TD width="156">
            <P align=center><INPUT onclick=CalcT(this.form) type=button value="Calc 

p"></P></TD></TR></TBODY></TABLE></CENTER></DIV>
    </TD><!--
//******************************************************************************************************************

********************
-->
  </TR>
  </TBODY></TABLE>
  
  </FORM></BODY></HTML>

 * 
 * 
 * **/
