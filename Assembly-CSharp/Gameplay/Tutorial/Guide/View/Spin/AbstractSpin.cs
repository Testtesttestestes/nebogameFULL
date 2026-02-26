using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Shapes;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Spin
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	public abstract class AbstractSpin : IDisposable
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x00005B08 File Offset: 0x00003D08
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A9")]
		public float Duration
		{
			[Token(Token = "0x6001AB5")]
			[Address(RVA = "0x6C45", Offset = "0x6C45", VA = "0x6C45")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001AB6")]
			[Address(RVA = "0x6C46", Offset = "0x6C46", VA = "0x6C46")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x00005B20 File Offset: 0x00003D20
		// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AA")]
		public int LoopCount
		{
			[Token(Token = "0x6001AB7")]
			[Address(RVA = "0x6C47", Offset = "0x6C47", VA = "0x6C47")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x6C48", Offset = "0x6C48", VA = "0x6C48")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AB")]
		public Transform Transform
		{
			[Token(Token = "0x6001AB9")]
			[Address(RVA = "0x6C49", Offset = "0x6C49", VA = "0x6C49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x6C4A", Offset = "0x6C4A", VA = "0x6C4A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AC")]
		public AbstractShape Shape
		{
			[Token(Token = "0x6001ABB")]
			[Address(RVA = "0x6C4B", Offset = "0x6C4B", VA = "0x6C4B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0x6C4C", Offset = "0x6C4C", VA = "0x6C4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001ABD RID: 6845
		[Token(Token = "0x6001ABD")]
		public abstract void Start();

		// Token: 0x06001ABE RID: 6846
		[Token(Token = "0x6001ABE")]
		public abstract void Stop();

		// Token: 0x06001ABF RID: 6847
		[Token(Token = "0x6001ABF")]
		public abstract void Dispose();

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0x6C4D", Offset = "0x6C4D", VA = "0x6C4D")]
		protected AbstractSpin()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Spin_AbstractSpin___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  float param3;
		  int iVar3;
		  
		  if (DAT_ram_00a5845d == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLoops_Tweener___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_Spin_CircleSpin___c__DisplayClass1_0__Start_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_Spin_CircleSpin___c__DisplayClass1_0_TypeInfo);
		    DAT_ram_00a5845d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_Spin_CircleSpin___c__DisplayClass1_0_TypeInfo);
		  *(int **)(iVar1 + 8) = param1;
		  if (param1[6] != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,*(undefined4 *)(*param1 + 0xf4));
		  }
		  iVar3 = *(int *)param1[5];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		                    ((int *)param1[5],*(undefined4 *)(iVar3 + 0xec));
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(iVar3 + 0x10);
		  param3 = (float)param1[2];
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_float__TypeInfo);
		  DG_Tweening_TweenCallback_int___Invoke
		            (uVar2,iVar1,
		             Method_Gameplay_Tutorial_Guide_View_Spin_CircleSpin___c__DisplayClass1_0__Start_b__0__,
		             0);
		  uVar2 = DG_Tweening_DOTween___c__DisplayClass67_0___To_b__1(0.0,6.2831855,param3,uVar2,0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_
		                    (uVar2,param1[3],Method_DG_Tweening_TweenSettingsExtensions_SetLoops_Tweener___)
		  ;
		  iVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,1,Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		  param1[6] = iVar1;
		  return;
		}
		*/

		}
	}
}
