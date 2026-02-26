using System;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View.Groups
{
	// Token: 0x02000800 RID: 2048
	[Token(Token = "0x2000800")]
	public class FrescoListElement : MonoBehaviour
	{
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000967")]
		private string White
		{
			[Token(Token = "0x6003008")]
			[Address(RVA = "0x806E", Offset = "0x806E", VA = "0x806E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000968")]
		private string Green
		{
			[Token(Token = "0x6003009")]
			[Address(RVA = "0x806F", Offset = "0x806F", VA = "0x806F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000969")]
		private string Purple
		{
			[Token(Token = "0x600300A")]
			[Address(RVA = "0x8070", Offset = "0x8070", VA = "0x8070")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300B")]
		[Address(RVA = "0x8071", Offset = "0x8071", VA = "0x8071")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Fresco_View_Groups_FrescoListElement__Start(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x58);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),
		               *(undefined8 *)(*(int *)(*(int *)(param1 + 0x14) + 0x4c) + 0x10),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600300C RID: 12300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300C")]
		[Address(RVA = "0x8072", Offset = "0x8072", VA = "0x8072")]
		private void FrescoClickedHandler()
		{
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300D")]
		[Address(RVA = "0x8073", Offset = "0x8073", VA = "0x8073")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300E")]
		[Address(RVA = "0x1AD7", Offset = "0x1AD7", VA = "0x1AD7")]
		public void Init(Protocol.Fresco.Fresco fresco, Protocol.Dic.Fresco.Types.FrescoDic frescoDic, int i, bool isOwn, Action<ulong> onFrescoClick)
		{
		/* --- GHIDRA: Init ---
		int * Gameplay_Fresco_View_Groups_FrescoListElement__Init(int *param1)
		
		{
		  System_Collections_Generic_SortedDictionary_Enumerator_object__object____ctor
		            (param1[1],
		             Method_System_Collections_Generic_SortedDictionary_Enumerator_Fresco__Fresco_Types_FrescoDic__Dispose__
		            );
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300F")]
		[Address(RVA = "0x8074", Offset = "0x8074", VA = "0x8074")]
		public FrescoListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_View_Groups_FrescoListElement___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57585 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_Groups_FrescoListElement___c_TypeInfo);
		    DAT_ram_00a57585 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Fresco_View_Groups_FrescoListElement___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Fresco_View_Groups_FrescoListElement___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private FrescoFieldMini _field;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _number;

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04001A4D RID: 6733
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04001A4E RID: 6734
		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _check;

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _white;

		// Token: 0x04001A50 RID: 6736
		[Token(Token = "0x4001A50")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _green;

		// Token: 0x04001A51 RID: 6737
		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _purple;

		// Token: 0x04001A52 RID: 6738
		[Token(Token = "0x4001A52")]
		[FieldOffset(Offset = "0x58")]
		private Action<ulong> _onFrescoClick;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_White ---
		undefined4 Gameplay_Fresco_View_Groups_FrescoListElement__get_White(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = *(undefined8 *)(param1 + 0x40);
		  local_10 = *(undefined8 *)(param1 + 0x38);
		  uVar1 = UnityEngine_ColorUtility__DoTryParseHtmlColor(&local_10,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Green ---
		undefined4 Gameplay_Fresco_View_Groups_FrescoListElement__get_Green(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = *(undefined8 *)(param1 + 0x50);
		  local_10 = *(undefined8 *)(param1 + 0x48);
		  uVar1 = UnityEngine_ColorUtility__DoTryParseHtmlColor(&local_10,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Purple ---
		void Gameplay_Fresco_View_Groups_FrescoListElement__get_Purple(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57583 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_View_Groups_FrescoListElement_FrescoClickedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57583 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Fresco_View_Groups_FrescoListElement_FrescoClickedHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
