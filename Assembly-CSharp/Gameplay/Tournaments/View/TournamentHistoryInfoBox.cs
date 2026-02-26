using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	public class TournamentHistoryInfoBox : MonoBehaviour
	{
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F3")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x6DA4", Offset = "0x6DA4", VA = "0x6DA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F4")]
		public UserViewWithNickname WinnerView
		{
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x6DA5", Offset = "0x6DA5", VA = "0x6DA5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F5")]
		public TournamentBank Bank
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x6DA6", Offset = "0x6DA6", VA = "0x6DA6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x6DA7", Offset = "0x6DA7", VA = "0x6DA7")]
		public void SetGladiatorsAndViewersCount(int fightersCount, long viewersCount)
		{
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x6DA8", Offset = "0x6DA8", VA = "0x6DA8")]
		public TournamentHistoryInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Tournaments_View_TournamentHistoryInfoBox___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12673);
		    DAT_ram_00a584f4 = '\x01';
		  }
		  return StringLiteral_12673;
		}
		*/

		}

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private UserViewWithNickname _winnerView;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TournamentBank _bank;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _gladiatorsCountLine;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _viewersCountLine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Bank ---
		void Gameplay_Tournaments_View_TournamentHistoryInfoBox__get_Bank
		               (int param1,undefined4 param2,undefined8 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  local_10 = param3;
		  local_4 = param2;
		  if (DAT_ram_00a584f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15169);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15150);
		    DAT_ram_00a584f3 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15150,1,0,1,0,0,0,0);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar3 = func_ii_4443(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,StringLiteral_21978,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,uVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar1,0);
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15169,1,0,1,0,0,0,0);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar2 = UnityEngine_GameObject__SetActive(&local_10,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar1,StringLiteral_21978,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar4 = Core_GameLocalization__GetTranslation(uVar4,uVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar4,0);
		  return;
		}
		*/

}
