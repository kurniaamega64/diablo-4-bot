using D4Bot.Engine.Domain.Models;

namespace D4Bot.Engine.Domain.Contracts;

public interface IWalletProvider
{
    Task<WalletVault> CreateVaultAsync(string label, string mnemonic, string passphrase, CancellationToken cancellationToken);

    Task<WalletVault?> LoadVaultAsync(string vaultId, CancellationToken cancellationToken);

    Task<IReadOnlyList<WalletAccount>> DeriveAccountsAsync(WalletVault vault, NetworkDescriptor network, int accountCount, CancellationToken cancellationToken);

    Task<string> DecryptSeedForSessionAsync(WalletVault vault, string passphrase, CancellationToken cancellationToken);
}
