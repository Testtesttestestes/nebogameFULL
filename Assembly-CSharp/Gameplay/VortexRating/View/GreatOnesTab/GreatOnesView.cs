using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.VortexRating.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.VortexRating.View.GreatOnesTab
{
	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	public class GreatOnesView : MonoBehaviour
	{
		// Token: 0x1400010E RID: 270
		// (add) Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600153E RID: 5438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010E")]
		public event Action<GreatUserView> LikeButtonClickedEvent
		{
			[Token(Token = "0x600153D")]
			[Address(RVA = "0x66FF", Offset = "0x66FF", VA = "0x66FF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600153E")]
			[Address(RVA = "0x6700", Offset = "0x6700", VA = "0x6700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000380")]
		public TextMeshProUGUI RatingPointsText
		{
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x6701", Offset = "0x6701", VA = "0x6701")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x6702", Offset = "0x6702", VA = "0x6702")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView__Start(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a581c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView_LikeButtonClickedEventHandler__
		              );
		    DAT_ram_00a581c3 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar5 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_GreatUserView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param1,
		                 Method_Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView_LikeButtonClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a581c6 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		        DAT_ram_00a581c6 = '\x01';
		      }
		      param1_00 = *(int *)(iVar4 + 0x2c);
		      do {
		        iVar2 = 0;
		        param1_02 = func_ii_7048(param1_00,param1_01,0);
		        param2_00 = System_Action_GreatUserView__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_GreatUserView__TypeInfo), iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar4 + 0x2c,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x6703", Offset = "0x6703", VA = "0x6703")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x6704", Offset = "0x6704", VA = "0x6704")]
		private void LikeButtonClickedEventHandler(GreatUserView user)
		{
		/* --- GHIDRA: LikeButtonClickedEventHandler ---
		undefined4
		Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView__LikeButtonClickedEventHandler
		          (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a581c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GreatUserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_GreatUserData__TypeInfo);
		    DAT_ram_00a581c4 = '\x01';
		  }
		  do {
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_GreatUserData__TypeInfo == *piVar5) {
		          puVar2 = (uint *)(iVar4 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x80eb4f11;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_GreatUserData__TypeInfo,0);
		code_r0x80eb4f11:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar4 <= iVar3) {
		      return *(undefined4 *)(param1 + 0x10);
		    }
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_GreatUserData__TypeInfo == *piVar5) {
		          puVar2 = (uint *)(iVar4 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x80eb4f90;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_GreatUserData__TypeInfo,0)
		    ;
		code_r0x80eb4f90:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar3,puVar2[1]);
		    Gameplay_VortexRating_View_GreatOnesTab_GreatUserView__OnDestroy
		              (*(undefined4 *)(*(int *)(param1 + 0x10) + iVar3 * 4 + 0x10),param2_00,param2_00);
		    iVar3 = iVar3 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x6705", Offset = "0x6705", VA = "0x6705")]
		public GreatUserView[] Init(IList<GreatUserData> userDatas)
		{
			return null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x6706", Offset = "0x6706", VA = "0x6706")]
		public GreatOnesView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		    DAT_ram_00a581c5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GreatUserView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GreatUserView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GreatUserView[] _greatUsers;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _ratingPointsText;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_LikeButtonClickedEvent ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView__add_LikeButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		    DAT_ram_00a581c1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GreatUserView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GreatUserView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_RatingPointsText ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView__get_RatingPointsText
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a581c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView_LikeButtonClickedEventHandler__
		              );
		    DAT_ram_00a581c2 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar5 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_GreatUserView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param1,
		                 Method_Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView_LikeButtonClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a581c5 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		        DAT_ram_00a581c5 = '\x01';
		      }
		      param1_00 = *(int *)(iVar4 + 0x2c);
		      do {
		        iVar2 = 0;
		        param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		        param2_00 = System_Action_GreatUserView__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_GreatUserView__TypeInfo), iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar4 + 0x2c,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

}
