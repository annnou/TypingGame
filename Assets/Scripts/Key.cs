using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Key : MonoBehaviour
{
    private PlayerInput input = null;

    public enum Keycode
    {
        a,b,c,d,e,f,g,
        h,i,j,k,l,m,n,
        o,p,q,r,s,t,
        u,v,w,x,y,z,
        A,B,C,D,E,F,G,
        H,I,J,K,L,M,N,
        O,P,Q,R,S,T,U,
        V,W,X,Y,Z,
        non,
    }

    private void Start()
    {
        
    }

    class KeyCode
    {
        public Keycode KeycodeName { get; private set; }

        public float time;

        public KeyCode(Keycode k)
        {
            KeycodeName = k;
            time = 0;
        }
    }

    class KeyCodes
    {
        public List<KeyCode> Keys { get; private set; } = new List<KeyCode>();

        public KeyCodes()
        {
            int keyCount = System.Enum.GetNames(typeof(Keycode)).Length;

            for(int i = 0; i < keyCount; i++)
            {
                Keycode k = (Keycode)System.Enum.ToObject(typeof(Keycode), i);

                KeyCode key = new KeyCode(k);

                Keys.Add(key);
            }
        }
    }

    KeyCodes keycodes = new KeyCodes();

    Keycode KEY = Keycode.non;

    private void Update()
    {
        SwitchUpdateFunction();
    }

    private void SwitchUpdateFunction()
    {
        switch (KEY)
        {
            case Keycode.a: a(); break;
            case Keycode.b: b(); break;
            case Keycode.c: c(); break;
            case Keycode.d: d(); break;
            case Keycode.e: e(); break;
            case Keycode.f: f(); break;
            case Keycode.g: g(); break;
            case Keycode.h: h(); break;
            case Keycode.i: i(); break;
            case Keycode.j: j(); break;
            case Keycode.k: k(); break;
            case Keycode.l: l(); break;
            case Keycode.m: m(); break;
            case Keycode.n: n(); break;
            case Keycode.o: o(); break;
            case Keycode.p: p(); break;
            case Keycode.q: q(); break;
            case Keycode.r: r(); break;
            case Keycode.s: s(); break;
            case Keycode.t: t(); break;
            case Keycode.u: u(); break;
            case Keycode.v: v(); break;
            case Keycode.w: w(); break;
            case Keycode.x: x(); break;
            case Keycode.y: y(); break;
            case Keycode.z: z(); break;
            case Keycode.A: A(); break;
            case Keycode.B: B(); break;
            case Keycode.C: C(); break;
            case Keycode.D: D(); break;
            case Keycode.E: E(); break;
            case Keycode.F: F(); break;
            case Keycode.G: G(); break;
            case Keycode.H: H(); break;
            case Keycode.I: I(); break;
            case Keycode.J: J(); break;
            case Keycode.K: K(); break;
            case Keycode.L: L(); break;
            case Keycode.M: M(); break;
            case Keycode.N: N(); break;
            case Keycode.O: O(); break;
            case Keycode.P: P(); break;
            case Keycode.Q: Q(); break;
            case Keycode.R: R(); break;
            case Keycode.S: S(); break;
            case Keycode.T: T(); break;
            case Keycode.U: U(); break;
            case Keycode.V: V(); break;
            case Keycode.W: W(); break;
            case Keycode.X: X(); break;
            case Keycode.Y: Y(); break;
            case Keycode.Z: Z(); break;
            case Keycode.non:
            default: break;
        }
    }

    #region Key code a ~ z ~ A ~ Z

    private void a()
    {

    }

    private void b()
    {

    }

    private void c()
    {

    }

    private void d()
    {

    }

    private void e()
    {

    }

    private void f()
    {

    }

    private void g()
    {

    }

    private void h()
    {

    }

    private void i()
    {

    }

    private void j()
    {

    }

    private void k()
    {

    }

    private void l()
    {

    }

    private void m()
    {

    }

    private void n()
    {

    }

    private void o()
    {

    }

    private void p()
    {

    }

    private void q()
    {

    }

    private void r()
    {

    }

    private void s()
    {

    }

    private void t()
    {

    }

    private void u()
    {

    }

    private void v()
    {

    }

    private void w()
    {

    }

    private void x()
    {

    }

    private void y()
    {

    }

    private void z()
    {

    }

    private void A()
    {

    }

    private void B()
    {

    }

    private void C()
    {

    }

    private void D()
    {

    }

    private void E()
    {

    }

    private void F()
    {

    }

    private void G()
    {

    }

    private void H()
    {

    }

    private void I()
    {

    }

    private void J()
    {

    }

    private void K()
    {

    }

    private void L()
    {

    }

    private void M()
    {

    }

    private void N()
    {

    }

    private void O()
    {

    }

    private void P()
    {

    }

    private void Q()
    {

    }

    private void R()
    {

    }

    private void S()
    {

    }

    private void T()
    {

    }

    private void U()
    {

    }

    private void V()
    {

    }

    private void W()
    {

    }

    private void X()
    {

    }

    private void Y()
    {

    }

    private void Z()
    {

    }
    #endregion

    #region InputSystem key code  a ~ z ~ A ~ Z

    private void KeyPush_a(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_b(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_c(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_d(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_e(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_f(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_g(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_h(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_i(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_j(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_k(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_l(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_m(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_n(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_o(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_p(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_q(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_r(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_s(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_t(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_u(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_v(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_w(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_x(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_y(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_z(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_A(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_B(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_C(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_D(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_E(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_F(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_G(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_H(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_I(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_J(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_K(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_L(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_M(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_N(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_O(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_P(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_Q(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_R(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_S(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_T(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_U(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_V(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_W(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_X(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_Y(InputAction.CallbackContext info)
    {

    }

    private void KeyPush_Z(InputAction.CallbackContext info)
    {

    }

    #endregion
}