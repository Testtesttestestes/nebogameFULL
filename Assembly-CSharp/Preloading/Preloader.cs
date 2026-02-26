using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.Preloader;
using UnityEngine;

namespace Preloading
{
	// Token: 0x02000E37 RID: 3639
	[Token(Token = "0x2000E37")]
	public class Preloader : MonoBehaviour
	{
		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06005927 RID: 22823 RVA: 0x0000FD98 File Offset: 0x0000DF98
		// (set) Token: 0x06005928 RID: 22824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700122B")]
		private float SumStepsWeights
		{
			[Token(Token = "0x6005927")]
			[Address(RVA = "0xA679", Offset = "0xA679", VA = "0xA679")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005928")]
			[Address(RVA = "0xA67A", Offset = "0xA67A", VA = "0xA67A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700122C")]
		public PreloaderView PreloaderView
		{
			[Token(Token = "0x6005929")]
			[Address(RVA = "0xA67B", Offset = "0xA67B", VA = "0xA67B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592A")]
		[Address(RVA = "0xA67C", Offset = "0xA67C", VA = "0xA67C")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Preloading_Preloader__Awake(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63c08 == '\0') {
		    Mono_Security_ASN1__get_Item(&Preloading_Preloader__Start_d__9_TypeInfo);
		    DAT_ram_00a63c08 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Preloading_Preloader__Start_d__9_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600592B")]
		[Address(RVA = "0xA67D", Offset = "0xA67D", VA = "0xA67D")]
		private IEnumerator Start()
		{
		/* --- GHIDRA: Start ---
		void Preloading_Preloader__Start(undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63c09 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_196);
		    DAT_ram_00a63c09 = '\x01';
		  }
		  if (param3 == 4) {
		    param1_00 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                          (param1,StringLiteral_196,param2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(param1_00,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592C")]
		[Address(RVA = "0xA67E", Offset = "0xA67E", VA = "0xA67E")]
		private static void ApplicationOnLogMessageReceived(string condition, string stacktrace, LogType type)
		{
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592D")]
		[Address(RVA = "0x227D", Offset = "0x227D", VA = "0x227D")]
		public void Hide()
		{
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592E")]
		[Address(RVA = "0xA67F", Offset = "0xA67F", VA = "0xA67F")]
		public void Show()
		{
		/* --- GHIDRA: Show ---
		void Preloading_Preloader__Show(int param1,float param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  float fVar4;
		  uint uVar5;
		  uint uVar6;
		  uint uVar7;
		  uint uVar8;
		  
		  fVar4 = 0.0;
		  uVar6 = 0;
		  uVar5 = 0;
		  iVar2 = *(int *)(param1 + 0x14);
		  uVar7 = param3 - 1;
		  if (0 < (int)uVar7) {
		    if (param3 - 2U < 3) {
		      iVar1 = 0;
		    }
		    else {
		      iVar1 = 0;
		      iVar3 = iVar2 + 0x10;
		      do {
		        uVar8 = iVar1 * 4;
		        fVar4 = fVar4 + *(float *)(iVar3 + uVar8) + *(float *)(iVar3 + (uVar8 | 4)) +
		                *(float *)(iVar3 + (uVar8 | 8)) + *(float *)(iVar3 + (uVar8 | 0xc));
		        iVar1 = iVar1 + 4;
		        uVar5 = uVar5 + 4;
		      } while (uVar5 != (uVar7 & 0xfffffffc));
		    }
		    if ((uVar7 & 3) != 0) {
		      do {
		        fVar4 = fVar4 + *(float *)(iVar2 + iVar1 * 4 + 0x10);
		        iVar1 = iVar1 + 1;
		        uVar6 = uVar6 + 1;
		      } while (uVar6 != (uVar7 & 3));
		    }
		  }
		  UI_Preloader_PreloaderView__SetProgress
		            (*(undefined4 *)(param1 + 0x10),*(float *)(iVar2 + uVar7 * 4 + 0x10) * param2 + fVar4,
		             *(float *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592F")]
		[Address(RVA = "0xA680", Offset = "0xA680", VA = "0xA680")]
		public void SetProgressOfPart(float progressOfStep, int currentStepIndex)
		{
		/* --- GHIDRA: SetProgressOfPart ---
		void Preloading_Preloader__SetProgressOfPart(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63c0a == '\0') {
		    Mono_Security_ASN1__get_Item(&float___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__E647529BA632623D5825BA27455F2C78593A50E728BF0851EEC16A50BB786E07
		              );
		    DAT_ram_00a63c0a = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid(float___TypeInfo,3);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_00,
		             Field__PrivateImplementationDetails__E647529BA632623D5825BA27455F2C78593A50E728BF0851EEC16A50BB786E07
		             ,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005930 RID: 22832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005930")]
		[Address(RVA = "0xA681", Offset = "0xA681", VA = "0xA681")]
		public Preloader()
		{
		}

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PreloaderView _preloaderView;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x14")]
		private readonly float[] StepsWeights;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PreloaderView ---
		/* WARNING: Type propagation algorithm not settling */
		
		void Preloading_Preloader__get_PreloaderView(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  float fVar2;
		  undefined4 param1_01;
		  undefined8 local_20;
		  ushort local_14 [7];
		  ushort local_6;
		  undefined2 local_4;
		  ushort local_2;
		  
		  if (DAT_ram_00a63c07 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_LogCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&UI_Preloader_PreloaderView_PreloaderInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Preloading_Preloader_ApplicationOnLogMessageReceived__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Resources_Load_AppBuildInfo___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_514);
		    DAT_ram_00a63c07 = '\x01';
		  }
		  local_2 = 0;
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  UnityEngine_Application__get_runInBackground(1,0);
		  uVar1 = unnamed_function_1417(UnityEngine_Application_LogCallback_TypeInfo);
		  UnityEngine_Application_MemoryUsageChangedCallback__Invoke
		            (uVar1,0,Method_Preloading_Preloader_ApplicationOnLogMessageReceived__,0);
		  UnityEngine_Application__HasLogCallback(uVar1,0);
		  UnityEngine_Screen__set_orientation(0xffffffff,0);
		  System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_2,0,Method_System_Nullable_bool___ctor__);
		  local_6 = local_2;
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  local_4 = 0;
		  local_14[2] = 0;
		  local_14[3] = 0;
		  local_14[4] = 0;
		  local_14[5] = 0;
		  local_14[1] = 0;
		  local_14[0] = local_6;
		  local_20 = 0;
		  DG_Tweening_DOTween__set_isQuitting(local_14 + 1,local_14,&local_20,0);
		  DG_Tweening_DOTween__Init(0xfa,0x96,0);
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Core_ProtocolMessageFactoriesRepository___ctor(0);
		  uVar1 = UnityEngine_Resources__GetBuiltinResource_object_
		                    (uVar1,Method_UnityEngine_Resources_Load_AppBuildInfo___);
		  param1_00 = unnamed_function_1417(UI_Preloader_PreloaderView_PreloaderInfo_TypeInfo);
		  Google_Protobuf_JsonTokenizer___ctor(param1_00,uVar1,StringLiteral_514,0);
		  UI_Preloader_PreloaderView__SetProgress(param1_01,param1_00,0);
		  fVar2 = System_Linq_Enumerable__Sum(*(undefined4 *)(param1 + 0x14),0);
		  *(float *)(param1 + 0x18) = fVar2;
		  return;
		}
		*/

}
