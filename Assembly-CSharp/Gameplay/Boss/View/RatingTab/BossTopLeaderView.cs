using System;
using Gameplay.Boss.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;

namespace Gameplay.Boss.View.RatingTab
{
	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x2000B67")]
	public class BossTopLeaderView : MonoBehaviour
	{
		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046CF RID: 18127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E10")]
		public BossCaptainRatingData CaptainRating
		{
			[Token(Token = "0x60046CE")]
			[Address(RVA = "0x9564", Offset = "0x9564", VA = "0x9564")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046CF")]
			[Address(RVA = "0x9565", Offset = "0x9565", VA = "0x9565")]
			set
			{
			}
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x9566", Offset = "0x9566", VA = "0x9566")]
		private void DataOnCaptainUserDataChangedEvent()
		{
		/* --- GHIDRA: DataOnCaptainUserDataChangedEvent ---
		void Gameplay_Boss_View_RatingTab_BossTopLeaderView__DataOnCaptainUserDataChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_View_RatingTab_BossTopLeaderView__get_CaptainRating(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x9567", Offset = "0x9567", VA = "0x9567")]
		private void OnDestroy()
		{
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x9568", Offset = "0x9568", VA = "0x9568")]
		public BossTopLeaderView()
		{
		}

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _nickname;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x1C")]
		private BossCaptainRatingData _captainRating;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CaptainRating ---
		void Gameplay_Boss_View_RatingTab_BossTopLeaderView__get_CaptainRating
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a579f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_RatingTab_BossTopLeaderView_DataOnCaptainUserDataChangedEvent__
		              );
		    DAT_ram_00a579f8 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x1c);
		  if (iVar6 != 0) {
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_View_RatingTab_BossTopLeaderView_DataOnCaptainUserDataChangedEvent__
		               ,0);
		    if (DAT_ram_00a57a75 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57a75 = '\x01';
		    }
		    iVar5 = *(int *)(iVar6 + 0x18);
		    do {
		      piVar4 = (int *)func_ii_7048(iVar5,uVar3,0);
		      if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		        System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar6 + 0x18,piVar4,iVar5);
		      bVar1 = iVar2 != iVar5;
		      iVar5 = iVar2;
		    } while (bVar1);
		  }
		  *(int *)(param1 + 0x1c) = param2;
		  if (param2 != 0) {
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_View_RatingTab_BossTopLeaderView_DataOnCaptainUserDataChangedEvent__
		               ,0);
		    if (DAT_ram_00a57a74 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57a74 = '\x01';
		    }
		    iVar6 = *(int *)(param2 + 0x18);
		    do {
		      piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar6,uVar3,0);
		      if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		        System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(param2 + 0x18,piVar4,iVar6);
		      bVar1 = iVar5 != iVar6;
		      iVar6 = iVar5;
		    } while (bVar1);
		    iVar6 = *(int *)(param1 + 0x1c);
		    if (*(int *)(iVar6 + 0x14) != 0) {
		      piVar4 = *(int **)(param1 + 0x18);
		      uVar3 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                        (*(int *)(iVar6 + 0x14),0);
		      iVar6 = *piVar4;
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		                (piVar4,uVar3,*(undefined4 *)(iVar6 + 0x2d4));
		      Gameplay_Rating_View_UserView__get_UserData
		                (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x14),0);
		      iVar6 = *(int *)(param1 + 0x1c);
		    }
		    UI_Elements_Counters_CounterAutoHide___ctor
		              (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(*(int *)(iVar6 + 8) + 0x20),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CaptainRating ---
		void Gameplay_Boss_View_RatingTab_BossTopLeaderView__set_CaptainRating(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x1c) + 0x14);
		  if (iVar2 != 0) {
		    piVar3 = *(int **)(param1 + 0x18);
		    uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(iVar2,0);
		    iVar2 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		    Gameplay_Rating_View_UserView__get_UserData
		              (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x14),0);
		  }
		  return;
		}
		*/

}
