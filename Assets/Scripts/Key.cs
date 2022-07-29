using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Key : MonoBehaviour
{
    [SerializeField]
    private TextAsset _textData = null;

    [SerializeField]
    private Text _text = null;

    private PlayerInput input = null;

    //scene manager is control this obect
    private SceneManager _SMinstance = null;    

    private int mojiNum = 0;
    private string moji = null;
    private string mojicode = null;
    private string[] mojicodes = null;
    private bool view = false;
    private bool first = false;

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
        _SMinstance = SceneManager.instance;
        _SMinstance.textBoxView = true;
        input = _SMinstance.GetComponent<PlayerInput>();

        input.SwitchCurrentActionMap("Keyboad");
        var inputKey = input.actions.FindActionMap("Keyboad");
        #region input key “o˜^
        inputKey["ButtonA"].started += KeyPush_a;
        inputKey["ButtonB"].started += KeyPush_b;
        inputKey["ButtonC"].started += KeyPush_c;
        inputKey["ButtonD"].started += KeyPush_d;
        inputKey["ButtonE"].started += KeyPush_e;
        inputKey["ButtonF"].started += KeyPush_f;
        inputKey["ButtonG"].started += KeyPush_g;
        inputKey["ButtonH"].started += KeyPush_h;
        inputKey["ButtonI"].started += KeyPush_i;
        inputKey["ButtonJ"].started += KeyPush_j;
        inputKey["ButtonK"].started += KeyPush_k;
        inputKey["ButtonL"].started += KeyPush_l;
        inputKey["ButtonM"].started += KeyPush_m;
        inputKey["ButtonN"].started += KeyPush_n;
        inputKey["ButtonO"].started += KeyPush_o;
        inputKey["ButtonP"].started += KeyPush_p;
        inputKey["ButtonQ"].started += KeyPush_q;
        inputKey["ButtonR"].started += KeyPush_r;
        inputKey["ButtonS"].started += KeyPush_s;
        inputKey["ButtonT"].started += KeyPush_t;
        inputKey["ButtonU"].started += KeyPush_u;
        inputKey["ButtonV"].started += KeyPush_v;
        inputKey["ButtonW"].started += KeyPush_w;
        inputKey["ButtonX"].started += KeyPush_x;
        inputKey["ButtonY"].started += KeyPush_y;
        inputKey["ButtonZ"].started += KeyPush_z;
        #endregion

        mojicodes = _textData.text.Split(char.Parse("\n"));

        view = true;
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

        if(view == true)
        {
            if(first == false)
            {
                mojiNum = Random.Range(0, mojicodes.Length - 1);
                moji = mojicodes[mojiNum];
                first = true;
            }

            if (moji.Remove(1) == mojicode)
            {
                MojiCodesDone();
                mojicode = null;
                view = false;
                if (moji.Length - 1 > 0)
                    StartCoroutine(StopWait());
                else
                    StartCoroutine(StopWait_long());
            }
        }

        _text.text = moji;
    }

    private void SwitchUpdateFunction()
    {
        switch (KEY)
        {
            #region keycodes
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
                #endregion
        }
    }

    #region Key code a ~ z ~ A ~ Z

    private void a()
    {
        mojicode = "a";
        KEY = Keycode.non;
    }

    private void b()
    {
        mojicode = "b";
        KEY = Keycode.non;
    }

    private void c()
    {
        mojicode = "c";
        KEY = Keycode.non;
    }

    private void d()
    {
        mojicode = "d";
        KEY = Keycode.non;
    }

    private void e()
    {
        mojicode = "e";
        KEY = Keycode.non;
    }

    private void f()
    {
        mojicode = "f";
        KEY = Keycode.non;
    }

    private void g()
    {
        mojicode = "g";
        KEY = Keycode.non;
    }

    private void h()
    {
        mojicode = "h";
        KEY = Keycode.non;
    }

    private void i()
    {
        mojicode = "i";
        KEY = Keycode.non;
    }

    private void j()
    {
        mojicode = "j";
        KEY = Keycode.non;
    }

    private void k()
    {
        mojicode = "k";
        KEY = Keycode.non;
    }

    private void l()
    {
        mojicode = "l";
        KEY = Keycode.non;
    }

    private void m()
    {
        mojicode = "m";
        KEY = Keycode.non;
    }

    private void n()
    {
        mojicode = "n";
        KEY = Keycode.non;
    }

    private void o()
    {
        mojicode = "o";
        KEY = Keycode.non;
    }

    private void p()
    {
        mojicode = "p";
        KEY = Keycode.non;
    }

    private void q()
    {
        mojicode = "q";
        KEY = Keycode.non;
    }

    private void r()
    {
        mojicode = "r";
        KEY = Keycode.non;
    }

    private void s()
    {
        mojicode = "s";
        KEY = Keycode.non;
    }

    private void t()
    {
        mojicode = "t";
        KEY = Keycode.non;
    }

    private void u()
    {
        mojicode = "u";
        KEY = Keycode.non;
    }

    private void v()
    {
        mojicode = "v";
        KEY = Keycode.non;
    }

    private void w()
    {
        mojicode = "w";
        KEY = Keycode.non;
    }

    private void x()
    {
        mojicode = "x";
        KEY = Keycode.non;
    }

    private void y()
    {
        mojicode = "y";
        KEY = Keycode.non;
    }

    private void z()
    {
        mojicode = "z";
        KEY = Keycode.non;
    }

    private void A()
    {
        KEY = Keycode.non;
    }

    private void B()
    {
        KEY = Keycode.non;
    }

    private void C()
    {
        KEY = Keycode.non;
    }

    private void D()
    {
        KEY = Keycode.non;
    }

    private void E()
    {
        KEY = Keycode.non;
    }

    private void F()
    {
        KEY = Keycode.non;
    }

    private void G()
    {
        KEY = Keycode.non;
    }

    private void H()
    {
        KEY = Keycode.non;
    }

    private void I()
    {
        KEY = Keycode.non;
    }

    private void J()
    {
        KEY = Keycode.non;
    }

    private void K()
    {
        KEY = Keycode.non;
    }

    private void L()
    {
        KEY = Keycode.non;
    }

    private void M()
    {
        KEY = Keycode.non;
    }

    private void N()
    {
        KEY = Keycode.non;
    }

    private void O()
    {
        KEY = Keycode.non;
    }

    private void P()
    {
        KEY = Keycode.non;
    }

    private void Q()
    {
        KEY = Keycode.non;
    }

    private void R()
    {
        KEY = Keycode.non;
    }

    private void S()
    {
        KEY = Keycode.non;
    }

    private void T()
    {
        KEY = Keycode.non;
    }

    private void U()
    {
        KEY = Keycode.non;
    }

    private void V()
    {
        KEY = Keycode.non;
    }

    private void W()
    {
        KEY = Keycode.non;
    }

    private void X()
    {
        KEY = Keycode.non;
    }

    private void Y()
    {
        KEY = Keycode.non;
    }

    private void Z()
    {
        KEY = Keycode.non;
    }
    #endregion

    #region InputSystem key code  a ~ z ~ A ~ Z

    private void KeyPush_a(InputAction.CallbackContext info)
    {
        KEY = Keycode.a;
    }

    private void KeyPush_b(InputAction.CallbackContext info)
    {
        KEY = Keycode.b;
    }

    private void KeyPush_c(InputAction.CallbackContext info)
    {
        KEY = Keycode.c;
    }

    private void KeyPush_d(InputAction.CallbackContext info)
    {
        KEY = Keycode.d;
    }

    private void KeyPush_e(InputAction.CallbackContext info)
    {
        KEY = Keycode.e;
    }

    private void KeyPush_f(InputAction.CallbackContext info)
    {
        KEY = Keycode.f;
    }

    private void KeyPush_g(InputAction.CallbackContext info)
    {
        KEY = Keycode.g;
    }

    private void KeyPush_h(InputAction.CallbackContext info)
    {
        KEY = Keycode.h;
    }

    private void KeyPush_i(InputAction.CallbackContext info)
    {
        KEY = Keycode.i;
    }

    private void KeyPush_j(InputAction.CallbackContext info)
    {
        KEY = Keycode.j;
    }

    private void KeyPush_k(InputAction.CallbackContext info)
    {
        KEY = Keycode.k;
    }

    private void KeyPush_l(InputAction.CallbackContext info)
    {
        KEY = Keycode.l;
    }

    private void KeyPush_m(InputAction.CallbackContext info)
    {
        KEY = Keycode.m;
    }

    private void KeyPush_n(InputAction.CallbackContext info)
    {
        KEY = Keycode.n;
    }

    private void KeyPush_o(InputAction.CallbackContext info)
    {
        KEY = Keycode.o;
    }

    private void KeyPush_p(InputAction.CallbackContext info)
    {
        KEY = Keycode.p;
    }

    private void KeyPush_q(InputAction.CallbackContext info)
    {
        KEY = Keycode.q;
    }

    private void KeyPush_r(InputAction.CallbackContext info)
    {
        KEY = Keycode.r;
    }

    private void KeyPush_s(InputAction.CallbackContext info)
    {
        KEY = Keycode.s;
    }

    private void KeyPush_t(InputAction.CallbackContext info)
    {
        KEY = Keycode.t;
    }

    private void KeyPush_u(InputAction.CallbackContext info)
    {
        KEY = Keycode.u;
    }

    private void KeyPush_v(InputAction.CallbackContext info)
    {
        KEY = Keycode.v;
    }

    private void KeyPush_w(InputAction.CallbackContext info)
    {
        KEY = Keycode.w;
    }

    private void KeyPush_x(InputAction.CallbackContext info)
    {
        KEY = Keycode.x;
    }

    private void KeyPush_y(InputAction.CallbackContext info)
    {
        KEY = Keycode.y;
    }

    private void KeyPush_z(InputAction.CallbackContext info)
    {
        KEY = Keycode.z;
    }

    private void KeyPush_A(InputAction.CallbackContext info)
    {
        KEY = Keycode.A;
    }

    private void KeyPush_B(InputAction.CallbackContext info)
    {
        KEY = Keycode.B;
    }

    private void KeyPush_C(InputAction.CallbackContext info)
    {
        KEY = Keycode.C;
    }

    private void KeyPush_D(InputAction.CallbackContext info)
    {
        KEY = Keycode.D;
    }

    private void KeyPush_E(InputAction.CallbackContext info)
    {
        KEY = Keycode.E;
    }

    private void KeyPush_F(InputAction.CallbackContext info)
    {
        KEY = Keycode.F;
    }

    private void KeyPush_G(InputAction.CallbackContext info)
    {
        KEY = Keycode.G;
    }

    private void KeyPush_H(InputAction.CallbackContext info)
    {
        KEY = Keycode.H;
    }

    private void KeyPush_I(InputAction.CallbackContext info)
    {
        KEY = Keycode.I;
    }

    private void KeyPush_J(InputAction.CallbackContext info)
    {
        KEY = Keycode.J;
    }

    private void KeyPush_K(InputAction.CallbackContext info)
    {
        KEY = Keycode.K;
    }

    private void KeyPush_L(InputAction.CallbackContext info)
    {
        KEY = Keycode.L;
    }

    private void KeyPush_M(InputAction.CallbackContext info)
    {
        KEY = Keycode.M;
    }

    private void KeyPush_N(InputAction.CallbackContext info)
    {
        KEY = Keycode.N;
    }

    private void KeyPush_O(InputAction.CallbackContext info)
    {
        KEY = Keycode.O;
    }

    private void KeyPush_P(InputAction.CallbackContext info)
    {
        KEY = Keycode.P;
    }

    private void KeyPush_Q(InputAction.CallbackContext info)
    {
        KEY = Keycode.Q;
    }

    private void KeyPush_R(InputAction.CallbackContext info)
    {
        KEY = Keycode.R;
    }

    private void KeyPush_S(InputAction.CallbackContext info)
    {
        KEY = Keycode.S;
    }

    private void KeyPush_T(InputAction.CallbackContext info)
    {
        KEY = Keycode.T;
    }

    private void KeyPush_U(InputAction.CallbackContext info)
    {
        KEY = Keycode.U;
    }

    private void KeyPush_V(InputAction.CallbackContext info)
    {
        KEY = Keycode.V;
    }

    private void KeyPush_W(InputAction.CallbackContext info)
    {
        KEY = Keycode.W;
    }

    private void KeyPush_X(InputAction.CallbackContext info)
    {
        KEY = Keycode.X;
    }

    private void KeyPush_Y(InputAction.CallbackContext info)
    {
        KEY = Keycode.Y;
    }

    private void KeyPush_Z(InputAction.CallbackContext info)
    {
        KEY = Keycode.Z;
    }

    #endregion

    void MojiCodesDone()
    {
        moji = moji.Remove(0, 1);
    }

    IEnumerator StopWait()
    {
        yield return new WaitForSeconds(0.01f);

        view = true;

        yield return null;
    }

    IEnumerator StopWait_long()
    {
        yield return new WaitForSeconds(1f);

        //this object has been exhausted because you have finished typing
        _SMinstance.textBoxView = false;
        Destroy(this.gameObject);

        yield return null;
    }
}