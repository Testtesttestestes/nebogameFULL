using System;
using Il2CppDummyDll;
using UI.SkinsV2;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utils.Cam
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class FlickerFixer : MonoBehaviour
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x57AE", Offset = "0x57AE", VA = "0x57AE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x57AF", Offset = "0x57AF", VA = "0x57AF")]
		private void Awake()
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x57B0", Offset = "0x57B0", VA = "0x57B0")]
		private void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode arg1)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x57B1", Offset = "0x57B1", VA = "0x57B1")]
		private void SceneManagerOnSceneUnloaded(Scene scene)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x57B2", Offset = "0x57B2", VA = "0x57B2")]
		private void HandleLoading()
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x57B3", Offset = "0x57B3", VA = "0x57B3")]
		public FlickerFixer()
		{
		}

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _stub;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RawImageSkinResolver _skinResolver;
	}
}
