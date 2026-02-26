using System;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000954 RID: 2388
	[Token(Token = "0x2000954")]
	public abstract class AbstractPetView : MonoBehaviour, IPetView
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B27")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x6003896")]
			[Address(RVA = "0x8840", Offset = "0x8840", VA = "0x8840", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003897")]
			[Address(RVA = "0x8841", Offset = "0x8841", VA = "0x8841", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x0000B448 File Offset: 0x00009648
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B28")]
		public bool Visible
		{
			[Token(Token = "0x6003898")]
			[Address(RVA = "0x8842", Offset = "0x8842", VA = "0x8842", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003899")]
			[Address(RVA = "0x8843", Offset = "0x8843", VA = "0x8843", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B29")]
		public PetData Data
		{
			[Token(Token = "0x600389A")]
			[Address(RVA = "0x8844", Offset = "0x8844", VA = "0x8844", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600389B")]
			[Address(RVA = "0x8845", Offset = "0x8845", VA = "0x8845", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x0000B460 File Offset: 0x00009660
		// (set) Token: 0x0600389D RID: 14493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2A")]
		public bool IsDead
		{
			[Token(Token = "0x600389C")]
			[Address(RVA = "0x8846", Offset = "0x8846", VA = "0x8846", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600389D")]
			[Address(RVA = "0x8847", Offset = "0x8847", VA = "0x8847")]
			protected set
			{
			}
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x8848", Offset = "0x8848", VA = "0x8848", Slot = "11")]
		public void UpdateHealth(float delay)
		{
		/* --- GHIDRA: <UpdateHealth>b__16_0 ---
		int Gameplay_Combat_View_Players_Pet_AbstractPetView___UpdateHealth_b__16_0
		              (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *local_4;
		  
		  if (DAT_ram_00a5670f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_IPetView___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_PetData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_PetData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_PetData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12539);
		    DAT_ram_00a5670f = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar3 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(param1 + 0x10),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_IPetView___);
		  if (iVar3 == 0) {
		    uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar5 = unnamed_function_1417(uVar5);
		    uVar6 = unnamed_function_2232(&StringLiteral_12370);
		    System_String__Concat(uVar5,uVar6,0);
		    uVar6 = unnamed_function_2232(&Method_Gameplay_Combat_View_Players_Pet_PetAvatar_GetData__);
		    func_ii_1050(uVar5,uVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = 0;
		  iVar3 = unnamed_function_1417(UI_ToolTip_ToolTipData_PetData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar3,StringLiteral_12539,Method_UI_ToolTip_ToolTipData_PetData___ctor__);
		  piVar1 = local_4;
		  iVar7 = *local_4;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80c6d386;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(local_4,Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo,4);
		code_r0x80c6d386:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar1,puVar4[1]);
		  *(undefined4 *)(iVar3 + 0x1c) = uVar5;
		  return iVar3;
		}
		*/

		}

		// Token: 0x0600389F RID: 14495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x8849", Offset = "0x8849", VA = "0x8849")]
		protected void OnDisable()
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x884A", Offset = "0x884A", VA = "0x884A")]
		protected void OnEnable()
		{
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x884B", Offset = "0x884B", VA = "0x884B")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060038A2 RID: 14498
		[Token(Token = "0x60038A2")]
		protected abstract void HandleDataChanged();

		// Token: 0x060038A3 RID: 14499
		[Token(Token = "0x60038A3")]
		protected abstract void HandleVisibleChanged();

		// Token: 0x060038A4 RID: 14500
		[Token(Token = "0x60038A4")]
		protected abstract void HandleIsDeadChanged();

		// Token: 0x060038A5 RID: 14501
		[Token(Token = "0x60038A5")]
		protected abstract void DisplayCurrentHealth(PetData petData, UserSkillDic userSkillDic);

		// Token: 0x060038A6 RID: 14502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038A6")]
		[Address(RVA = "0x884C", Offset = "0x884C", VA = "0x884C")]
		protected AbstractPetView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_Pet_AbstractPetView___ctor(int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		            (param1,param1[6],param1[4],*(undefined4 *)(*param1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x04001F4B RID: 8011
		[Token(Token = "0x4001F4B")]
		[FieldOffset(Offset = "0x14")]
		private bool _visible;

		// Token: 0x04001F4C RID: 8012
		[Token(Token = "0x4001F4C")]
		[FieldOffset(Offset = "0x18")]
		private PetData _pet;

		// Token: 0x04001F4D RID: 8013
		[Token(Token = "0x4001F4D")]
		[FieldOffset(Offset = "0x1C")]
		protected bool _isDead;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Visible ---
		void Gameplay_Combat_View_Players_Pet_AbstractPetView__get_Visible
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  if (param2 != *(byte *)(param1 + 5)) {
		    *(char *)(param1 + 5) = (char)param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Combat_View_Players_Pet_AbstractPetView__get_Data
		               (int *param1,int param2,undefined4 param3)
		
		{
		  if (param2 != param1[6]) {
		    param1[6] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x120) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x124));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_IsDead ---
		void Gameplay_Combat_View_Players_Pet_AbstractPetView__get_IsDead
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  if (param2 != *(byte *)(param1 + 7)) {
		    *(char *)(param1 + 7) = (char)param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x134));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsDead ---
		void Gameplay_Combat_View_Players_Pet_AbstractPetView__set_IsDead
		               (int *param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5670e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Players_Pet_AbstractPetView__UpdateHealth_b__16_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		    DAT_ram_00a5670e = '\x01';
		  }
		  if (param2 <= 0.0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		              (param1,param1[6],param1[4],*(undefined4 *)(*param1 + 0x13c));
		    return;
		  }
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_Players_Pet_AbstractPetView__UpdateHealth_b__16_0__,0);
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(param2,uVar1,1,0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,param2_00,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		  return;
		}
		*/

}
